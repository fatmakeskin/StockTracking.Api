using Business.Services;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace StockTracking.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class StockController : ControllerBase
    {
        private readonly StockService<Stock> stockService;
        public StockController(StockService<Stock> _stockService)
        {
            stockService = _stockService;
        }

    }
}
