using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngrafiiExecutor
{
    public class PackageAdded_Result
    {
        public string packageId { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public _documents documents { get; set; }
        public _signers signers { get; set; }
    }

    public class _documents
    {
        public string documentId { get; set; }
        public string packageId { get; set; }
        public string fileName { get; set; }
        public _revisions revisions { get; set; }

    }

    public class _revisions
    {
        public string documentId { get; set; }
        public string revisionsId { get; set; }
        public int revisionNumber { get; set; }
        public string signerId { get; set; }
    }

    public class _signers
    {
        public string packageId { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string type { get; set; }
        public string timeExpires { get; set; } //format seems to be "YYYY-MM-DDTHH:mm:ss:fffZ"
    }
}
