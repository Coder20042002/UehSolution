using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Khoa
    {
        public string makhoa { get; set; }
        public string tenkhoa { get; set; }
        public List<Giangvien> giangviens { get; set; }
        public List<Student> students { get; set; }
    }
}
