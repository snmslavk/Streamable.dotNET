using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamable.dotNET.Models
{
    class UploadFileModel
    {
        public string url { get; set; }
        public string filePath { get; set; }
    }

    class UploadAuthFileModel : UploadFileModel
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}
