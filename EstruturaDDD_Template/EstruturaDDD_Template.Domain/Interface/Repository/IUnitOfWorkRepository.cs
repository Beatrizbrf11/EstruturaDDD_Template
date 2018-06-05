using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Repository
{
    public interface IUnitOfWorkRepository<T> where T : class
    {
        int Save(T model);
        int Update(T model);
        void Delete(T model);
        IEnumerable<T> GetAll();
        T GetById(object id);
        IEnumerable<T> Where(Expression<Func<T, bool>> expression);
        IEnumerable<T> OrderBy(Expression<System.Func<T, bool>> expression);
    }
}
