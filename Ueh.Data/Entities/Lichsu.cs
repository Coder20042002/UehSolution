using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class Lichsu
    {
        public Guid Id { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGian { get; set; }

        public Guid MaDk { get; set; }
        public Dangkycuoi Dangkycuoi { get; set; }

    }

}
