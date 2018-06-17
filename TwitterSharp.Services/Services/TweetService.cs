using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSharp.Data.Context;
using TwitterSharp.Data.Models;

namespace TwitterSharp.Services.Services
{
    public interface ITweetService
    {
        Task PostTweet(Tweet tweet, TwitterSharpContext ctx);
        Task DeleteTweet(Tweet tweet, TwitterSharpContext ctx);
    }

    public class TweetService : ITweetService
    {
        public TweetService()
        {
        }

        public async Task DeleteTweet(Tweet tweet, TwitterSharpContext ctx)
        {
            ctx.Tweets.Remove(tweet);
            await ctx.SaveChangesAsync();
        }

        public async Task PostTweet(Tweet tweet, TwitterSharpContext ctx)
        {
            ctx.Tweets.Add(tweet);
            await ctx.SaveChangesAsync();

            if (tweet.User == null)
            {

            }
        }
    }
}
