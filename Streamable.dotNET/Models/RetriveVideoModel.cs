using Newtonsoft.Json;

namespace Streamable.dotNET.Models
{
    public class RetriveVideoModel
    {
        public class Files
        {
            public FilesFormat mp4 { get; set; }

            [JsonProperty("mp4-mobile")]
            public FilesFormat mp4_mobile { get; set; }

            public FilesFormat webm { get; set; }

            [JsonProperty("webm-mobile")]
            public FilesFormat webm_mobile { get; set; }

            

        }

        public class FilesFormat
        {
            public int status { get; set; }
            public string url { get; set; }
            public int framerate { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public int bitrate { get; set; }
            public int size { get; set; }
        }

        public int status { get; set; }

        public Files files { get; set; }

        public string url_root { get; set; }
        public string thumbnail_url { get; set; }
        public string[] formats { get; set; }
        public string url { get; set; }
        public string message { get; set; }
        public string title { get; set; }
        public int percent { get; set; }
    }


}
