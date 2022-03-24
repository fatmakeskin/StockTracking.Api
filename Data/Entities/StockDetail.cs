using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class StockDetail
    {
        [Key]
        public int StockScale { get; set; }
        public int StockTrade { get; set; }
        public int StockDailyInterval { get; set; }

        public int StockId { get; set; }
        public string StockName { get; set; }
        public Stock Stock { get; set; }
    }
}
