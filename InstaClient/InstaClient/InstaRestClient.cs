using System;
using System.Linq;
using System.Net;
using RestSharp;
namespace InstaClient
{
    public class InstaRestClient : RestClient
    {
        private const string USER_AGENT =
             "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) " +
             "AppleWebKit/537.36 (KHTML, like Gecko) " +
             "Chrome/45.0.2414.0 Safari/537.36";

        public string CSRF { get; set; }
        public bool IsLogined { get;private set; }
        public InstaRestClient()
        {
            IsLogined = false;
            CSRF = null;
            this.UserAgent = USER_AGENT;
            this.CookieContainer = new CookieContainer();
            this.BaseUrl = new Uri("https://www.instagram.com");
            this.AddDefaultHeader("Accept-Encoding", "gzip, deflate");
            this.AddDefaultHeader("Host", "www.instagram.com");
            this.AddDefaultHeader("Origin", "https://www.instagram.com");
            this.AddDefaultHeader("X-Requested-With", "XMLHttpRequest");
            this.AddDefaultHeader("X-Instagram-AJAX", "1");
            this.AddDefaultHeader("Referer", this.BaseUrl.ToString());
        }
        public InstaRestClient(IWebProxy proxy)
        {       
            CSRF = null;
            this.Proxy = proxy;
            this.UserAgent = USER_AGENT;
            this.CookieContainer = new CookieContainer();
            this.BaseUrl = new Uri("https://www.instagram.com");
            this.AddDefaultHeader("Accept-Encoding", "gzip, deflate");
            this.AddDefaultHeader("Host", "www.instagram.com");
            this.AddDefaultHeader("Origin", "https://www.instagram.com");
            this.AddDefaultHeader("Referer", "https://www.instagram.com/");
            this.AddDefaultHeader("X-Requested-With", "XMLHttpRequest");
            this.AddDefaultHeader("X-Instagram-AJAX", "1");
            this.AddDefaultHeader("Referer", this.BaseUrl.ToString());
        }
        public override IRestResponse Execute(IRestRequest request)
        {
            request.AddHeader("X-CSRFToken", CSRF);
            var responce = base.Execute(request);
            try
            {
                CSRF = responce.Cookies.First(x => x.Name == "csrftoken").Value;
            }
            catch { CSRF = CSRF; }
            return responce;
        }
        public LoginResponse LogIn(string login, string password)
        {
            var firstRequest = new RestRequest("/", Method.GET);
            var firstResponse = this.Execute(firstRequest);
            var loginRequest = new RestRequest("/accounts/login/ajax/", Method.POST);
            loginRequest.AddParameter("username", login);
            loginRequest.AddParameter("password", password);
            var loginResponse = this.Execute<LoginResponse>(loginRequest);
            firstResponse = this.Execute(firstRequest);
            if (loginResponse.StatusCode == HttpStatusCode.OK)
            {
                if (loginResponse.Data.authenticated)
                {
                    IsLogined = true;
                }
                return loginResponse.Data;
            }
            else return null;
        }
        public IRestResponse<LikeResponse> LikeById(string id)
        {
            var likeRequest = new RestRequest("/web/likes/" + id + "/like/", Method.POST);
            var resp = this.Execute<LikeResponse>(likeRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp;
            }
            else return null;
        }

        public IRestResponse<FollowResponse> FollowById(string id)
        {
            var likeRequest = new RestRequest("/web/friendships/" + id + "/follow/", Method.POST);
            var resp = this.Execute<FollowResponse>(likeRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp;
            }
            else return null;
        }

        public UserInfo GetUserInfo(string login)
        {
            var freq = new RestRequest(login + "/?__a=1", Method.GET);
            var resp = this.Execute<UserInfo>(freq);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp.Data;
            }
            else return null;
        }

        public FollowResponse UnfollowByID(string id)
        {
            var likeRequest = new RestRequest("/web/friendships/" + id + "/unfollow/", Method.POST);
            var resp = this.Execute<FollowResponse>(likeRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp.Data;
            }
            else return null;
        }

        public PhotoInfo GetPhotoInfo(string shortcode)
        {
            var firstRequest = new RestRequest("/p/" + shortcode + "/?__a=1", Method.GET);
            var resp = this.Execute<PhotoInfo>(firstRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp.Data;
            }
            else return null;
        }

        public Follows GetFollows(params string[] prms)
        {
            var likeRequest = new RestRequest("/graphql/query/", Method.POST);
            if (prms.Length == 2)
            {
                likeRequest.AddParameter("variables", "{\"id\":\"" + prms[0] + "\",\"first\":" + prms[1] + "}");
            }
            else
            {
                likeRequest.AddParameter("variables", "{\"id\":\"" + prms[0] + "\",\"first\":" + prms[1] + ",\"after\":\"" + prms[2] + "\" }");
            }
            likeRequest.AddParameter("query_id", "17874545323001329");
            var resp = this.Execute<Follows>(likeRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp.Data;
            }
            else return null;

        }
        public LocalInfo GetLocalInfo(string link)
        {
            var firstRequest = new RestRequest(link + "/?__a=1", Method.GET);
            var resp = this.Execute<LocalInfo>(firstRequest);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                return resp.Data;
            }
            else return null;
        }
    }
}
