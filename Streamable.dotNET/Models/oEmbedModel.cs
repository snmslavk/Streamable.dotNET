using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamable.dotNET.Models
{
//    {
//  "author_url": null,
//  "height": 480,
//  "html": "<div class=\"streamable-embed-container\" style=\"width: 100%; height: 0px; position: relative; padding-bottom: 56.338%;\"><iframe class=\"streamable-embed\" src=\"https://streamable.com/e/ifjh\" frameborder=\"0\" scrolling=\"no\" style=\"width: 100%; height: 100%; position: absolute;\" allowfullscreen webkitallowfullscreen mozallowfullscreen></iframe></div>",
//  "provider_name": "Streamable",
//  "provider_url": "https://streamable.com",
//  "thumbnail_url": "//cdn.streamable.com/image/ifjh.jpg",
//  "title": "Puppy!",
//  "type": "video",
//  "version": "1.0",
//  "width": 848
//}

    public class oEmbedModel
    {
        public string author_url { get;set;}
        public int height { get; set; }
        public string html { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public int width { get; set; }
    }
}
