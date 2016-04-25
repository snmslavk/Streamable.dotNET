using Streamable.dotNET.Models;
using System;
using System.Net;
using System.Text;
using Streamable.dotNET.Interfaces;

namespace Streamable.dotNET
{
    class WebClientExtended : IWebClientExtended 
    {
        private void SetCredentials(
            WebClient wc, 
            string userName, 
            string password
            )
        {
            string credentials = Convert.ToBase64String(
                   Encoding.ASCII.GetBytes(userName + ":" + password));

            wc.Headers[HttpRequestHeader.Authorization] = string.Format(
                    "Basic {0}", credentials);
        }

        public UploadVideoResponse UploadFile(UploadAuthFileModel model)
        {
            return UploadFile(model.url,model.filePath,model.userName, model.password);
        }

        internal UploadVideoResponse UploadFile(UploadFileModel model)
        {
            return UploadFile(model);
        }

        public UploadVideoResponse UploadFile(
            string url, 
            string filePath, 
            string userName = null, 
            string password = null
            )
        {
            using (var client = new WebClient())
            {
                if (!String.IsNullOrEmpty(userName) || !String.IsNullOrEmpty(password))
                    SetCredentials(client, userName, password);

                return Json.Get_UploadVideoResponse(
                    Encoding.UTF8.GetString(
                        client.UploadFile(url, filePath)
                    )
                );


            }
        }

        public string GetData(
            string url,
            string userName = null,
            string password = null
            )
        {
            using (var client = new WebClient())
            {
                if (!String.IsNullOrEmpty(userName) || !String.IsNullOrEmpty(password))
                    SetCredentials(client, userName, password);

                return client.DownloadString(url);
            }
        }


    }
}
