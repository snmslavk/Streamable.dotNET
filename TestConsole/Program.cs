using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string url = "https://api.streamable.com/upload";
                string filePath = "c:\\temp\\zyra.mp4";
                string userName = "snmslavk";
                string password = "33looking";

                string credentials = Convert.ToBase64String(
                   Encoding.ASCII.GetBytes(userName + ":" + password));

                client.Headers[HttpRequestHeader.Authorization] = string.Format(
                    "Basic {0}", credentials);

                var zz = Encoding.UTF8.GetString(
                    client.UploadFile(url, filePath)
                    );
            }
        }
    }
}
