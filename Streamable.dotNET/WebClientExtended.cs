using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Streamable.dotNET.Models;

namespace Streamable.dotNET
{
    class WebClientExtended
    {
        protected void SetCredentials(WebClient wc, string userName, string password)
        {
            string credentials = Convert.ToBase64String(
                   Encoding.ASCII.GetBytes(userName + ":" + password));

            wc.Headers[HttpRequestHeader.Authorization] = string.Format(
                    "Basic {0}", credentials);
        }

        protected void UploadFile(UploadAuthFileModel model)
        {
            UploadFile(model.url,model.filePath,model.userName, model.password);
        }

        protected void UploadFile(UploadFileModel model)
        {
            UploadFile(model.url, model.filePath);
        }

        protected void UploadFile(string url, string filePath, string userName=null, string password=null)
        {
            using (WebClient client = new WebClient())
            {
                if (!String.IsNullOrEmpty(userName) || !String.IsNullOrEmpty(password))
                    SetCredentials(client, userName, password);

                var zz = Encoding.UTF8.GetString(
                    client.UploadFile(url, filePath)
                    );
            }
        }
    }
}
