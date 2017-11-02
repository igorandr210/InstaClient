# InstaClient
This library let you some features to manipulte Instagram without API.
First of all it's for getting base from geotegs and etc and making auto(liking/following).

# For Start:

- Create new exemplar of InstaRestClient class; 

 # Main Functions are:

# Login(Login,Password)
 - You must be logined first;
 - Use your login and password to get a csfr;

# GetUserInfo (Login)
- You can load information about user;
- Get ID, photos, check profile for private;

# GetLocalInfo(Link)
- get information from geotag(like a users photos and other...);
- link is string from geotag w/o(https://www.instagram.com/);
- example if you want to load info from (https://www.instagram.com/explore/locations/678815755560160/europekiev) you need to call GetLocalInfo("explore/locations/678815755560160/europekiev");

# FollowById(string id) and LikeById(string id)
- If you want to like you must to know photo ID;
- Follow similar with like,but you must to know "user_ID";
