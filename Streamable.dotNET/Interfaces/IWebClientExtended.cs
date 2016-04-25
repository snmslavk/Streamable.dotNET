using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streamable.dotNET.Models;

namespace Streamable.dotNET.Interfaces
{
    public interface IWebClientExtended
    {
        UploadVideoResponse UploadFile(UploadAuthFileModel model);
        UploadVideoResponse UploadFile(
            string url,
            string filePath,
            string userName = null,
            string password = null
            );

        string GetData(
            string url,
            string userName = null,
            string password = null
            );

    }
}
