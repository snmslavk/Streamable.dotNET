using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamable.dotNET.Models
{
    public class UserModel
    {
        public string bio { get; set; }
        public bool is_private { get; set; }
        public string photo_url { get; set; }
        public string user_name { get; set; }
    }
}
