using System.Collections.Generic;
using System.Linq;
using Tweetinvi;
using Tweetinvi.Models;

namespace FeedReader.Models
{
    public static class API
    {
        private static readonly string CONSUMERKEY = "c5GqLhCTW13bHhwm2gPOneqjr";
        private static readonly string CONSUMERSECRET = "nMyoNDb43KyPj4YcUbAAY9OkaQW0GeNbxz3kScqtrAfTZVoBdj";
        private static readonly string ACCESSTOKEN = "1083816113476128768-JseMTwmKbmiWL7NhuYY0FOFTq2iPvp";
        private static readonly string ACCESSSECRET = "zigrEHEEqGsyiB9iqw23r51bQbCYHXObnX3Bkr0AoAmum";

        private static List<ITweet> timeline;
        public static List<ITweet> GetTimeline { get { return timeline; } }

        public static void Authorize()
        {
            Auth.SetUserCredentials(CONSUMERKEY, CONSUMERSECRET, ACCESSTOKEN, ACCESSSECRET);
            var user = User.GetAuthenticatedUser();
        }

        public static void GetFeed()
        {
            try {
                timeline = Timeline.GetHomeTimeline(15).ToList();
            } catch (System.ArgumentNullException e)
            {
                
            }
        }
    }
}