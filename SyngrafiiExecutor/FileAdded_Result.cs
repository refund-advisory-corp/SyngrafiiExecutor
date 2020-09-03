using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngrafiiExecutor
{
    public class FileAdded_Result
    {
        public string folderID { get; set; }
        public string addPackageLInk { get; set; }
        public _files files { get; set; }
        public string action { get; set; }
    }

    public class _files
    {
        public string organizationId { get; set; }
        public string userId { get; set; }
        public string folderId { get; set; }
        public string externalId { get; set; }
        public string name { get; set; }
        public string timeCreated { get; set; } //format seems to be "YYYY-MM-DDTHH:mm:ss.fffffffZ"
        public string timeUpdated { get; set; }
        public string fileName { get; set; }
        public string fileSize { get; set; }
        public string fileMediaType { get; set; } //Expecting "application/pdf", i think
        public bool isConverted { get; set; }
        public bool isInvalid { get; set; }
        public bool isNotSupported { get; set; }
        public bool isPasswordProtected { get; set; }
        public int unlockAttempts { get; set; }
        public bool isProtected { get; set; }
        public string protectedClientId { get; set; }
        public bool isProtectedClientRequired { get; set; }
        public bool isPRotectedClientInvalid { get; set; }
        public string message { get; set; }
        public int pageCount { get; set; }
        public string thumbnail { get; set; }
        public string type { get; set; }
    }
}
