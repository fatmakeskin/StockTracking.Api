using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.IServices
{
    public interface IUserService
    {
        UserDto GetById(int id);
        IEnumerable<UserDto> GetAll();
        void Add(UserDto model);
        void Update(UserDto model);
        void Delete(UserDto model);

    }
}
