using RestSharp.Deserializers;


namespace InstaClient
{
    public class LikeResponse
    {
        [DeserializeAs(Name = "status")]
        public string status { get; set; }
    }
}
