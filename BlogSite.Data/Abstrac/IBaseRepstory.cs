﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Data.Abstrac
{
   public interface IBaseRepstory<T> where T:class
    {
        IQueryable<T> GetAll();
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
       
    }
}
