using System.Collections.Generic;
using Tweetinvi.Models;
using FeedReader.Models;

namespace FeedReader.Controllers
{
    public static class APIController
    {
        public static void Authorize()
        {
            API.Authorize();
        }

        public static List<ITweet> GetTimeline()
        {
            API.GetFeed();
            return API.GetTimeline;
        }
    }
}