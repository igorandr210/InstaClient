using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace InstaClient
{
    public class PhotoInfo
    {
        [DeserializeAs(Name = "graphql")]
        public sm graphql { get; set; }
        public class sm
        {
            [DeserializeAs(Name = "shortcode_media")]
            public node shortcode_media { get; set; }
        }
        public class node
        {
            [DeserializeAs(Name = "__typename")]
            public string __typename { get; set; }
            [DeserializeAs(Name = "id")]
            public string id { get; set; }
            [DeserializeAs(Name = "shortcode")]
            public string shortcode { get; set; }
            [DeserializeAs(Name = "dimensions")]
            public string dimensions { get; set; }
            [DeserializeAs(Name = "gating_info")]
            public string gating_info { get; set; }
            [DeserializeAs(Name = "media_preview")]
            public string media_preview { get; set; }
            [DeserializeAs(Name = "display_url")]
            public string display_url { get; set; }
            [DeserializeAs(Name = "is_video")]
            public bool is_video { get; set; }
            [DeserializeAs(Name = "edge_media_to_tagged_user")]
            public string edge_media_to_tagged_user { get; set; }
            [DeserializeAs(Name = "edge_media_to_caption")]
            public string edge_media_to_caption { get; set; }
            [DeserializeAs(Name = "caption_is_edited")]
            public string caption_is_edited { get; set; }
            [DeserializeAs(Name = "edge_media_to_comment")]
            public string edge_media_to_comment { get; set; }
            [DeserializeAs(Name = "comments_disabled")]
            public string comments_disabled { get; set; }
            [DeserializeAs(Name = "taken_at_timestamp")]
            public string taken_at_timestamp { get; set; }
            [DeserializeAs(Name = "edge_media_preview_like")]
            public string edge_media_preview_like { get; set; }
            [DeserializeAs(Name = "edge_media_to_sponsor_user")]
            public string edge_media_to_sponsor_user { get; set; }
            [DeserializeAs(Name = "location")]
            public string location { get; set; }
            [DeserializeAs(Name = "viewer_has_liked")]
            public bool viewer_has_liked { get; set; }
            [DeserializeAs(Name = "owner")]
            public own owner { get; set; }
            [DeserializeAs(Name = "is_ad")]
            public bool is_ad { get; set; }
            [DeserializeAs(Name = "edge_web_media_to_related_media")]
            public string edge_web_media_to_related_media { get; set; }
        }
        public class own
        {
            [DeserializeAs(Name = "id")]
            public string id { get; set; }
            [DeserializeAs(Name = "profile_pic_url")]
            public string is_ad { get; set; }
            [DeserializeAs(Name = "username")]
            public string username { get; set; }
            [DeserializeAs(Name = "followed_by_user")]
            public bool followed_by_user { get; set; }
            [DeserializeAs(Name = "full_name")]
            public string full_name { get; set; }
            [DeserializeAs(Name = "is_private")]
            public bool is_private { get; set; }
            [DeserializeAs(Name = "requested_by_user")]
            public bool requested_by_user { get; set; }
            [DeserializeAs(Name = "is_unpublished")]
            public bool is_unpublished { get; set; }
            [DeserializeAs(Name = "blocked_by_viewer")]
            public bool blocked_by_viewer { get; set; }
            [DeserializeAs(Name = "has_blocked_viewer")]
            public bool has_blocked_viewer { get; set; }

        }

    }
}
