using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Thongtindangky
    {
        public Guid madk { get; set; }
        public string masv { get; set; }
        public string tencongty { get; set; }
        public string vitri { get; set; }
        public string website { get; set; }
        public string nguoihuongdan { get; set; }
        public string chucvu { get; set; }
        public string email { get; set; }
        public string numberphone { get; set; }
        public string tendetai { get; set; }

        public Student student { get; set; }
        public Dangkycuoi dangkycuoi { get; set; }

    }
}
