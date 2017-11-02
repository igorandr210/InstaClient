using RestSharp.Deserializers;


namespace InstaInterface
{
    public class LikeResponse
    {
        [DeserializeAs(Name = "status")]
        public string status { get; set; }
    }
}
