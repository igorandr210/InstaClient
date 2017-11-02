using RestSharp.Deserializers;


namespace InstaClient
{
    public class FollowResponse
    {
        [DeserializeAs(Name = "status")]
        public string status { get; set; }
    }
}
