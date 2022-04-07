using Business.Base.IServices;
using Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace stock_tracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService stockService;
        public StockController(IStockService _stockService)
        {
            stockService = _stockService;
        }
        [HttpGet(nameof(GetStockById) + "/{stockId}")]
        public IActionResult GetStockById(int stockId)
        {
            try
            {
                stockService.GetById(stockId);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            try
            {
                var data = stockService.GetAll();
                return Ok(data);

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost(nameof(AddStock))]
        public IActionResult AddStock(StockDto model)
        {
            try
            {
                if (model != null)
                {
                    stockService.Add(model);
                    return Ok();
                }
                else
                    return BadRequest();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut(nameof(UpdateStock))]
        public IActionResult UpdateStock(StockDto model)
        {
            try
            {
                if (model != null)
                {
                    stockService.Update(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete(nameof(DeleteStock) + "/{stockId}")]
        public IActionResult DeleteStock(int stockId)
        {
            try
            {
                var model = stockService.GetById(stockId);
                if (model != null)
                {
                    stockService.Delete(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
