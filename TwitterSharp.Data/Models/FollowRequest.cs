using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSharp.Data.Models
{
    public class FollowRequest
    {
        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser Follower { get; set; }

        public virtual ApplicationUser Followed { get; set; }

        public bool Accepted { get; set; }

        public bool Declined { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
