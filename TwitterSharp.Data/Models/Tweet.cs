using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSharp.Data.Models
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 280, MinimumLength = 1, ErrorMessage = "Your Tweet must be between {1} and {0} characters.")]
        public string Text { get; set; }

        public bool Retweet { get; set; }

        public virtual Tweet OriginalTweet { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
