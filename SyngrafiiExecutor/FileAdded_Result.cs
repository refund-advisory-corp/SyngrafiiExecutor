using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngrafiiExecutor
{
    public class FileAdded_Result
    {
        public string folderId { get; set; }
        public string addPackageLink { get; set; }
        public _file[] files { get; set; }
        public string action { get; set; }
        public string eventId { get; set; }
    }

    public class _file
    {
        public string organizationId { get; set; }
        public string userId { get; set; }
        public string folderId { get; set; }
        public string fileId { get; set; }
        public object externalId { get; set; }
        public string name { get; set; }
        public DateTime timeCreated { get; set; } //format seems to be "YYYY-MM-DDTHH:mm:ss.fffffffZ"
        public object timeUpdated { get; set; }
        public string fileName { get; set; }
        public int fileSize { get; set; }
        public string fileType { get; set; }
        public string fileMediaType { get; set; } //Expecting "application/pdf", i think
        public bool isConverted { get; set; }
        public bool isInvalid { get; set; }
        public bool isNotSupported { get; set; }
        public bool isPasswordProtected { get; set; }
        public int unlockAttempts { get; set; }
        public bool isProtected { get; set; }
        public object protectedClientId { get; set; }
        public bool isProtectedClientRequired { get; set; }
        public bool isProtectedClientInvalid { get; set; }
        public object message { get; set; }
        public int pageCount { get; set; }
        public object thumbnail { get; set; }
        public string type { get; set; }
    }

}
