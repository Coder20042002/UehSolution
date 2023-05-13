using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Loai
    {
        public string maloai { get; set; }
        public string tenloaij { get; set; }
        public List<Dangkytruoc> dangkytruocs { get; set; }
        //public List<Dangkycuoi> dangkycuois { get; set; }
    }
}
