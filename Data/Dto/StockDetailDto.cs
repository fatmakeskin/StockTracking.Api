using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class StockDetailDto
    {        
        public int StockScale { get; set; }
        public int StockTrade { get; set; }
        public int StockDailyInterval { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }

    }
}
