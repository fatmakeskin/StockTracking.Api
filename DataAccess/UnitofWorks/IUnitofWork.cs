using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitofWork
{
    public interface IUnitofWork
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChange();
    }
}
