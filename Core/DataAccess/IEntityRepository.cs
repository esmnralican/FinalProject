using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı bizim evrensel katmanımız. Yani bütün .Net projelerinde kullanılabilir.Core katmanı diğer katmanları referans almamalı

namespace Core.DataAccess
{
   public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        //generic constraint
        //class : referans tip
        //IEntity : IEntity 
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId); asla ihtiyacımız yok. 10 ve 11. satır ile oldu
    }
}
