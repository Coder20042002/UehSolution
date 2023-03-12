using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.EF
{
    public class EmailInfo
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Body { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string IsBodyHtml { get; set; } = bool.TrueString;
    }
}
