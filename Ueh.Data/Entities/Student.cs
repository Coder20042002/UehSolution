using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Student
    {
        public string mssv { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public string className { get; set; }
        public string faculty { get; set; }
        public string idCard { get; set; }
        public string classStudentName { get; set; }
        public string birthday { get; set; }
        public string birthplace { get; set; }
        public string studyStatusId { get; set; }
        public string phoneNumber { get; set; }
        public string HDT { get; set; }

        public List<Dangkytruoc> dangkytruoc { get; set; }
        public List<Dangkycuoi> dangkycuoi { get; set; }
        public List<Lichsu> lichsus { get; set; }
        //public List<Thongtindangky> thongtindangkies { get; set; }
    }

}
