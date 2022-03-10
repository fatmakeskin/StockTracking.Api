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
    public class UserService : IUserService
    {
        private IUnitofWork uow;
        private IMapper mapper;

        public UserService(IMapper _mapper, IUnitofWork unitofWork)
        {
            mapper = _mapper;
            this.uow = unitofWork;
        }
        public void Add(UserDto model)
        {
            User result = mapper.Map<User>(model);
            uow.GetRepository<User>().Add(result);
            uow.SaveChange();
        }

        public void Delete(UserDto model)
        {
            User result = mapper.Map<User>(model);
            uow.GetRepository<User>().Delete(result);
            uow.SaveChange();
        }

        public IEnumerable<UserDto> GetAll()
        {
            var data = uow.GetRepository<User>().GetAll();
            IEnumerable<UserDto> result = mapper.Map<IEnumerable<UserDto>>(data);
            return result;
        }

        public UserDto GetById(int id)
        {
            User data = uow.GetRepository<User>().GetById(id);
            UserDto result = mapper.Map<UserDto>(data);
            return result;
        }

        public void Update(UserDto model)
        {
            User data = mapper.Map<User>(model);
            uow.GetRepository<User>().Update(data);
            uow.SaveChange();
        }
    }
}
