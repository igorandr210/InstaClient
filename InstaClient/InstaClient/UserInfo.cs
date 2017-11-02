using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace InstaClient
{
    public class UserInfo
    {
        [DeserializeAs(Name = "user")]
        public lst user { get; set; }
        public class lst
        {
            [DeserializeAs(Name = "biography")]
            public string biography { get; set; }
            [DeserializeAs(Name = "id")]
            public string id { get;set; }
            [DeserializeAs(Name = "is_private")]
            public bool is_private { get; set; }
            [DeserializeAs(Name = "followed_by")]
            public cnt followed_by { get; set; }
            [DeserializeAs(Name = "follows")]
            public cnt follows { get; set; }
            public class cnt
            {
                [DeserializeAs(Name = "count")]
                public string count { get; set; }
            }
            [DeserializeAs(Name = "media")]
            public mda media { get; set; }
            public class mda
            {
                [DeserializeAs(Name = "count")]
                public int count { get; set; }
                [DeserializeAs(Name = "nodes")]
                public List<nds> nodes { get; set; }
            }
            public class nds
            {
                [DeserializeAs(Name = "id")]
                public string id { get; set; }
                [DeserializeAs(Name = "code")]
                public string code { get; set; }
                [DeserializeAs(Name = "is_video")]
                public bool is_video { get; set; }
                [DeserializeAs(Name = "likes")]
                public cnt likes { get; set; }
            }
        }
    }
}
