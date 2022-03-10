using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.IServices
{
    public interface IStockService
    {
        StockDto GetById(int id);
        IEnumerable<StockDto> GetAll();
        void Add(StockDto model);
        void Update(StockDto model);
        void Delete(StockDto model);
    }
}
