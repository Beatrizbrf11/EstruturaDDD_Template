using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Repository
{
    public interface IRepository<T> 
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
    }
}
