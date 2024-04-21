using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    //generic constraint 
    //generic kısıtlama
    //Class: referans tip
    //Ientitiy: Ientitiy olabilir veya implemte edebilen tip olabilir
    //New(): new'lenebilir olmalı
    public interface IEntityRepository<T>where T: class,IEntitiy,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
