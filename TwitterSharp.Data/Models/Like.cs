using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSharp.Data.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        public virtual Tweet Tweet { get; set; }

        public virtual ApplicationUser User { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
