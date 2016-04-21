using Streamable.dotNET.Models;

namespace Streamable.dotNET.Interfaces
{
    public interface IStreamableAPI
    {
        UploadVideoResponse Upload(string filePath, string userName, string password);
        UploadVideoResponse Upload(string filePath);
        UploadVideoResponse Import(string filePath, string userName, string password);
        UploadVideoResponse Import(string filePath);
        RetriveVideoModel Retrive(string shortcode);
        UserModel RetrieveUser(string userName);
        UserModel RetrieveAuthUser(string userName, string password);
        oEmbedModel GEToEmbed(string urlVideo);
    }
}

