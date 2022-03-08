using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext masterContext;
        private readonly DbSet<T> dbSet;
        public Repository(DbContext _masterContext)
        {
            masterContext = _masterContext;
            dbSet = _masterContext.Set<T>();
        }
        public void Add(T model)
        {
            dbSet.Add(model);
        }

        public void Delete(T model)
        {
            masterContext.Entry(model).State = EntityState.Deleted;
            dbSet.Attach(model);
            dbSet.Remove(model);
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void Update(T model)
        {
            dbSet.Attach(model);
            masterContext.Entry(model).State = EntityState.Modified;
        }
    }
}
