using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace InstaInterface
{
    public class LocalInfo
    {
        [DeserializeAs(Name = "location")]
        public loc location { get; set; }
        [DeserializeAs(Name = "logging_page_id")]
        public string logging_page_id { get; set; }
        public class loc
        {
            [DeserializeAs(Name = "id")]
            public string id { get; set; }
            [DeserializeAs(Name = "name")]
            public string name { get; set; }
            [DeserializeAs(Name = "has_public_page")]
            public string has_public_page { get; set; }
            [DeserializeAs(Name = "lat")]
            public string lat { get; set; }
            [DeserializeAs(Name = "lng")]
            public string lng { get; set; }
            [DeserializeAs(Name = "slug")]
            public string slug { get; set; }
            [DeserializeAs(Name = "media")]
            public med media { get; set; }
            [DeserializeAs(Name = "top_posts")]
            public Dictionary<string, object> top_posts { get; set; }

        }
        public class med
        {
            [DeserializeAs(Name = "nodes")]
            public List<node> nodes { get; set; }
            [DeserializeAs(Name = "count")]
            public long count { get; set; }
            [DeserializeAs(Name = "page_info")]
            public Dictionary<string, object> page_info { get; set; }

        }
        public class node
        {
            [DeserializeAs(Name = "comments_disabled")]
            public bool comments_disabled { get; set; }
            [DeserializeAs(Name = "id")]
            public string id { get; set; }
            [DeserializeAs(Name = "dimensions")]
            public Dictionary<string, object> dimensions { get; set; }
            [DeserializeAs(Name = "owner")]
            public ownby owner { get; set; }
            [DeserializeAs(Name = "thumbnail_src")]
            public string thumbnail_scr { get; set; }
            [DeserializeAs(Name = "thumbnail_resources")]
            public List<object> thumbnail_res { get; set; }
            [DeserializeAs(Name = "is_video")]
            public bool is_video { get; set; }
            [DeserializeAs(Name = "code")]
            public string code { get; set; }
            [DeserializeAs(Name = "date")]
            public long date { get; set; }
            [DeserializeAs(Name = "display_scr")]
            public string display_scr { get; set; }
            [DeserializeAs(Name = "comments")]
            public Dictionary<string, object> comments { get; set; }
            [DeserializeAs(Name = "likes")]
            public Dictionary<string, object> likes { get; set; }
        }
        public class ownby
        {
            [DeserializeAs(Name = "id")]
            public string id { get; set; }
        }
    }
}
