﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId); asla ihtiyacımız yok.10 ve 11. satır ile oldu
    }
}