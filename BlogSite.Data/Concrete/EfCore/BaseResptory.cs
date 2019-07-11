using BlogSite.Data.Abstrac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Data.Concrete.EfCore
{
    public class BaseResptory<T> : IBaseRepstory<T> where T : class
    {
        private readonly DbContext context;
        public BaseResptory(BlogContext _context)
        {
           context = _context;
        }
        public bool Add(T entity)
        {
            context.Set<T>().Add(entity);
            try
            {
              return  context.SaveChanges() > 0;
            }
            catch 
            {
                return false;
               
            }
        }

        public bool Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            try
            {
                return context.SaveChanges() > 0;
            }
            catch
            {
                return false;

            }
        }

        public IQueryable<T> GetAll()
        {
          return  context.Set<T>();
        }

        public bool Update(T entity)
        {
            context.Set<T>().Update(entity);
            try
            {
                return context.SaveChanges() > 0;
            }
            catch
            {
                return false;

            }
        }
    }
}
