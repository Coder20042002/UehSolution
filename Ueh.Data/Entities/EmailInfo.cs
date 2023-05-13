using Email.UEH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Entities
{
    public class EmailInfo
    {
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Body { get; set; }
        public List<AttachFile> Files { get; set; }
        public string IsBodyHtml { get; set; } = bool.TrueString;
    }
}
