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
    public class CommentSevice : ICommentService
    {
        private IMapper mapper;
        private IUnitofWork uow;
        public CommentSevice(IMapper _mapper, IUnitofWork unitofWork)
        {
            mapper = _mapper;
            this.uow = unitofWork;
        }
        public void Add(CommentDto model)
        {

            Comment result = mapper.Map<Comment>(model);
            uow.GetRepository<Comment>().Add(result);
            uow.SaveChange();

        }

        public void Delete(CommentDto model)
        {

            Comment result = mapper.Map<Comment>(model);
            uow.GetRepository<Comment>().Delete(result);
            uow.SaveChange();

        }

        public IEnumerable<CommentDto> GetAll()
        {
            var data = uow.GetRepository<Comment>().GetAll();
            IEnumerable<CommentDto> result = mapper.Map<IEnumerable<CommentDto>>(data);
            return result;

        }

        public CommentDto GetById(int id)
        {

            var data = uow.GetRepository<Comment>().GetById(id);
            CommentDto result = mapper.Map<CommentDto>(data);
            return result;

        }

        public void Update(CommentDto model)
        {

            Comment result = mapper.Map<Comment>(model);
            uow.GetRepository<Comment>().Update(result);
            uow.SaveChange();

        }
    }
}
