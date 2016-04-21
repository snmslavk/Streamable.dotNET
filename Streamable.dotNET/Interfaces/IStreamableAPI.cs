using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streamable.dotNET.Models;

namespace Streamable.dotNET.Interfaces
{
    public interface IStreamableAPI
    {
        UploadVideoResponse Upload();
        UploadVideoResponse Import();
        void Retrive();
        UserModel RetrieveUser();
        void RetrieveAuthUser();
        oEmbedModel GEToEmbed();
    }
}

