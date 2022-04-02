using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public string StockName { get; set; }

        public List<Comment> Comments { get; set; }
        public List<StockDetail> StockDetail { get; set; }
    }
}
