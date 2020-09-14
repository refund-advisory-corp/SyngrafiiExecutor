using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngrafiiExecutor
{
    public class req_file
    {
        public string fileName { get; set; }
        public string fileUrl { get; set; }
    }

    public class AddPackageHelper
    {
        public string UploadPDFfile { get; set; }
        public string Owner1Email { get; set; }
        public string Owner2Email { get; set; }
        public string specialistFirstName { get; set; }
        public string specialistLastName { get; set; }
        public string specialistEmail { get; set; }
        public DateTime AppointmentTime { get; set; }
        public bool Owner1Present { get; set; }
        public bool Owner2Present { get; set; }
        public bool Owner1Sign { get; set; }
        public bool OWner2Sign { get; set; }
    }
}
