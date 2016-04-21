using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streamable.dotNET.Interfaces;
using Streamable.dotNET.Models;

namespace Streamable.dotNET
{
    public class StreamableAPI : IStreamableAPI
    {
        WebClientExtended client = null;

        public StreamableAPI()
        {
            client = new WebClientExtended();
        }

        
        public UploadVideoResponse Upload(string filePath, string userName, string password)
        {
            return client.UploadFile(Config.UploadUrl, filePath, userName, password);
        }

        public UploadVideoResponse Upload(string filePath)
        {
            return client.UploadFile(Config.UploadUrl, filePath);
        }

        public UploadVideoResponse Import(string videoUrl, string userName, string password)
        {
            return Json.Get_UploadVideoResponse(
                client.GetData(Config.ImportUrl + videoUrl, userName, password)
            );

        }

        public UploadVideoResponse Import(string videoUrl)
        {
            return Import(videoUrl,null,null);

        }

        public RetriveVideoModel Retrive(string shortcode)
        {
            return Json.Get_RetriveVideoModel(
                client.GetData(Config.RetriveUrl + shortcode)
                );

        }

        public UserModel RetrieveUser(string userName)
        {
            return Json.Get_UserModel(
                client.GetData(Config.RetriveUser + userName)
            );
        }

        public UserModel RetrieveAuthUser(string userName, string password)
        {
            return Json.Get_UserModel(
                client.GetData(Config.RetriveAuthUser, userName, password)
            );
        }

        public oEmbedModel GEToEmbed(string urlVideo)
        {
            return Json.Get_oEmbed(
                client.GetData(Config.GEToEmbed + urlVideo)
            );
        }

    }
}
