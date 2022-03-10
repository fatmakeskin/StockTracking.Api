using AutoMapper;
using Business.Base.IServices;
using Data.Dto;
using Data.Entities;
using DataAccess.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.Services
{
    public class StockService : IStockService
    {
        private IMapper mapper;
        private IUnitofWork uow;
        public StockService(IMapper _mapper, IUnitofWork unitofWork)
        {
            mapper = _mapper;
            this.uow = unitofWork;
        }
        public void Add(StockDto model)
        {
            Stock data = mapper.Map<Stock>(model);
            uow.GetRepository<Stock>().Add(data);
            uow.SaveChange();
        }

        public void Delete(StockDto model)
        {
            Stock data = mapper.Map<Stock>(model);
            uow.GetRepository<Stock>().Delete(data);
            uow.SaveChange();
        }

        public IEnumerable<StockDto> GetAll()
        {
            var data = uow.GetRepository<Stock>().GetAll();
            IEnumerable<StockDto> result = mapper.Map<IEnumerable<StockDto>>(data);
            return result;
        }

        public StockDto GetById(int id)
        {
            Stock data = uow.GetRepository<Stock>().GetById(id);
            StockDto result = mapper.Map<StockDto>(data);
            return result;
        }

        public void Update(StockDto model)
        {
            Stock data = mapper.Map<Stock>(model);
            uow.GetRepository<Stock>().Update(data);
            uow.SaveChange();
        }
    }
}
