using Business.BistConn.ConnService;
using Microsoft.AspNetCore.Mvc;

namespace stocktracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockDetailController :ControllerBase
    {
        public readonly ConnService connService;
        public StockDetailController(ConnService _connService)  
        {
            connService = _connService;
        }
        

    }
}
