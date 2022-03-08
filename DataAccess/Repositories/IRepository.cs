using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IRepository<T> where T : class 
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Delete(T model);
        void Update(T model);
    }
    
}
