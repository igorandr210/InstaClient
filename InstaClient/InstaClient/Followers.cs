using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace InstaClient
{
    public class Follows
    {
        [DeserializeAs(Name = "data")]
        public usr data { get; set; }
        [DeserializeAs(Name = "status")]
        public string status { get; set; }
        public class usr
        {
            [DeserializeAs(Name = "user")]
            public edgs user { get; set; }
            public class edgs
            {
                [DeserializeAs(Name = "edge_follow")]
                public lst edge_follow { get; set; }
                public class lst
                {
                    [DeserializeAs(Name = "count")]
                    public long count { get; set; }
                    [DeserializeAs(Name = "page_info")]
                    public pi page_info { get; set; }
                    public class pi
                    {
                        [DeserializeAs(Name = "has_next_page")]
                        public bool has_next_page { get; set; }
                        [DeserializeAs(Name = "end_cursor")]
                        public string end_cursor { get; set; }
                    }
                        [DeserializeAs(Name = "edges")]
                    public List<nd> edges { get; set; }
                    public class nd
                    {
                        [DeserializeAs(Name = "node")]
                        public edg node { get; set; }
                    }
                    public class edg
                    {
                        [DeserializeAs(Name = "id")]
                        public string id { get; set; }
                        [DeserializeAs(Name = "username")]
                        public string username { get; set; }
                        [DeserializeAs(Name = "full_name")]
                        public string full_name { get; set; }
                        [DeserializeAs(Name = "profile_pic_url")]
                        public string profile_pic_url { get; set; }
                        [DeserializeAs(Name = "is_verified")]
                        public bool is_verified { get; set; }
                        [DeserializeAs(Name = "followed_by_viewer")]
                        public bool followed_by_viewer { get; set; }
                        [DeserializeAs(Name = "requested_by_viewer")]
                        public bool requested_by_viewer { get; set; }
                    }
                } 
            }
        }
    }
   
}
