using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Giangvien
    {
        public string magv { get; set; }
        public string tengv { get; set; }
        public string makhoa { get; set; }

        public Khoa khoa { get; set; }
        public List<Dangkytruoc> dangkytruocs { get; set; }

        //public List<Lichsu> lichsus { get; set; }
        //public List<Thongtindangky> thongtindangkies { get; set; }
        //public List<Dangkycuoi> dangkycuoi { get; set; }


    }
}
