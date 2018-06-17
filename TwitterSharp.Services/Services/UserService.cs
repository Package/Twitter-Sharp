using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TwitterSharp.Data.Context;
using TwitterSharp.Data.Models;

namespace TwitterSharp.Services.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserByName(string username, TwitterSharpContext ctx);
    }

    public class UserService : IUserService
    {
        public Task<ApplicationUser> GetUserByName(string username, TwitterSharpContext ctx)
        {
            return ctx.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
