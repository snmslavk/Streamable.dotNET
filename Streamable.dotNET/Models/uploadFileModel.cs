
namespace Streamable.dotNET.Models
{
    public class UploadFileModel
    {
        public string url { get; set; }
        public string filePath { get; set; }
    }

    public class UploadAuthFileModel : UploadFileModel
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}
