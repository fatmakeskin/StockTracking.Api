using Business.BistConn.ConnService;
using Microsoft.AspNetCore.Mvc;

namespace stock_tracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockDetailController : ControllerBase
    {
        public readonly ConnService connService;
        public StockDetailController(ConnService _connService)
        {
            connService = _connService;
        }

    }
}
