using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSharp.Data.Models;

namespace TwitterSharp.Data.Context
{
    public class TwitterSharpContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<FollowRequest> FollowRequests { get; set; }
        public DbSet<Like> Likes { get; set; }

        public TwitterSharpContext()
            : base("DbConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterSharpContext Create()
        {
            return new TwitterSharpContext();
        }
    }
}
