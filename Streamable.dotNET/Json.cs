using Newtonsoft.Json;
using Streamable.dotNET.Models;

namespace Streamable.dotNET
{
    internal class Json
    {
        public static string Convert2Json(object o)
        {
            return JsonConvert.SerializeObject(o);
        }

        public static UploadVideoResponse Get_UploadVideoResponse(string s)
        {
            return (UploadVideoResponse)JsonConvert.DeserializeObject(s, typeof(UploadVideoResponse));
        }

        public static RetriveVideoModel Get_RetriveVideoModel(string s)
        {
            return (RetriveVideoModel)JsonConvert.DeserializeObject(s, typeof(RetriveVideoModel));
        }


        public static oEmbedModel Get_oEmbed(string s)
        {
            return (oEmbedModel)JsonConvert.DeserializeObject(s, typeof(oEmbedModel));
        }

        public static UserModel Get_UserModel(string s)
        {
            return (UserModel)JsonConvert.DeserializeObject(s, typeof(UserModel));
        }
    }
}
