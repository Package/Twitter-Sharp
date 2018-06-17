using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TwitterSharp.Data.Context;
using TwitterSharp.Data.Models;
using TwitterSharp.Services.Services;

namespace TwitterSharp.Controllers
{
    public class TweetsController : Controller
    {
        protected readonly ITweetService _tweetService;
        protected readonly IUserService _userService;
        protected readonly TwitterSharpContext _context;

        public TweetsController(ITweetService _tweetService,
                                IUserService _userService)
        {
            this._tweetService = _tweetService;
            this._userService = _userService;
            this._context = new TwitterSharpContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Tweet tweet)
        {
            if (ModelState.IsValid)
            {
                tweet.User = await _userService.GetUserByName(User.Identity.Name, _context);
                tweet.Timestamp = DateTime.UtcNow;
                await _tweetService.PostTweet(tweet, _context);
            }

            return View(tweet);
        }

        // GET: Tweets/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Tweet tweet = await db.Tweets.FindAsync(id);
        //    if (tweet == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tweet);
        //}

        //// POST: Tweets/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Tweet tweet = await db.Tweets.FindAsync(id);
        //    db.Tweets.Remove(tweet);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}
