using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Dangkytruoc
    {
        public Guid id { get; set; }
        public bool status { get; set; } = true;

        public string mssv { get; set; }
        public Student Student { get; set; }

        public string magv { get; set; }
        public Giangvien Giangvien { get; set; }

        public string madot { get; set; }
        public Dot Dot { get; set; }

        public string maloai { get; set; }
        public Loai Loai { get; set; }


    }
}
