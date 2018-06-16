using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSharp.Data.Models;

namespace TwitterSharp.Data.Context
{

    public class TwitterSharpContext : IdentityDbContext<ApplicationUser>
    {
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
