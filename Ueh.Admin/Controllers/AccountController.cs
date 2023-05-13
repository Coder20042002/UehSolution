using Login.ST.UEH;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.Host;
using System.Net.Mail;
using Ueh.Application.Services;
using Ueh.Data.Entities;

namespace Ueh.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IStudentService _studentService;

        public AccountController(IStudentService studentService)
        {
            this._studentService = studentService;
        }


        public ActionResult LoginStUeh(string returnUrl = "/home")
        {
            if (HttpContext.Session.Get("account") != null)
            {
                return Redirect(returnUrl);
            }
            string uri = Url.Action("LoginSTUehCallback", "Account", new RouteValueDictionary(new { returnUrl }),
                HttpContext.Request.Scheme, string.Empty);

            return Redirect("https://loginst.ueh.edu.vn/?returnUrl=" + uri);
        }

        [HttpGet]
        public ActionResult LoginSTUehCallback(string t, string returnUrl = null)
        {
            var obj = LoginStUEH.GetInfo(t);
            if (obj == null || string.IsNullOrEmpty(obj.email))
            {
                BadRequest();
            }
            if (obj.email.EndsWith("@st.ueh.edu.vn"))
            {
                var student = new Student
                {
                    mssv = obj.mssv,
                    password = obj.Password,
                    email = obj.email,
                    fullName = obj.hoten,
                    className = obj.lop,
                    faculty = obj.khoa,
                    idCard = obj.cmnd,
                    classStudentName = obj.classstudentname,
                    birthday = obj.birthday,
                    birthplace = obj.birthplace,
                    studyStatusId = obj.studystatusid,
                    phoneNumber = obj.phone,
                    HDT = obj.HDT
                };

                _studentService.AddStudent(student);
            }
            else
            {
                throw new HttpException(404, "File Not Found");
            }

            return Redirect(returnUrl);
        }

    }
}
