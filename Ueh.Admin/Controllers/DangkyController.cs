using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ueh.Data.EF;

namespace Ueh.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangkyController : ControllerBase
    {
        private readonly UEH_DbContext _context;
        public DangkyController(UEH_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

        }
    }
}
