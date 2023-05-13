using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Dot
    {
        public string maDot { get; set; }
        public string tenDot { get; set; }
        public DateTime starDate { get; set; }
        public DateTime endDate { get; set; }
        public bool status { get; set; }

        public List<Dangkytruoc> dangkytruocsList { get; set; }
        //public List<Dangkycuoi> dangkycuoiList { get; set; }

    }
}
