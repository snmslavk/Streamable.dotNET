using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Streamable.dotNET;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _client = new StreamableAPI();

            string filePath = "c:\\temp\\zyra.mp4";
            string userName = "YourUserName";
            string password = "YourPass";
            string urlImport = "https://cdn.streamable.com/video/mp4/mjk3.mp4";

            var res1 = _client.GEToEmbed("https://streamable.com/uz0t");

            var res21 = _client.Import(urlImport,
                userName,
                password);

            var res22 = _client.Import(urlImport);

            var res31 = _client.Upload(filePath, userName, password);
            var res32 = _client.Upload(filePath);

            var res4 = _client.Retrive("uz0t");

            var res5 = _client.RetrieveUser("snmslavk");

            var res6 = _client.RetrieveAuthUser(userName, password);

        }
    }
}
