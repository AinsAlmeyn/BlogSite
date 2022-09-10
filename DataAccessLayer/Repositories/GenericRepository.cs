using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using var c = new Context();
            c.Set<T>().Remove(item);
            c.SaveChanges(true);
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var c = new Context();
            c.Set<T>().Add(item);
            c.SaveChanges(true);
        }

        public void Update(T item)
        {
            using var c = new Context();
            c.Set<T>().Update(item);
            c.SaveChanges();
        }
    }
}
