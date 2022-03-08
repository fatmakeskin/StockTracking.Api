using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
