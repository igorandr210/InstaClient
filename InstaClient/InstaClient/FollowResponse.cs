using RestSharp.Deserializers;


namespace InstaInterface
{
    public class FollowResponse
    {
        [DeserializeAs(Name = "status")]
        public string status { get; set; }
    }
}
