using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Service
{
    public interface IBaseService<TEntityDTO> where TEntityDTO : EntruturaDDD_Template.IEntityDTO
    {
        void Add(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
        void Update(TEntityDTO entity);
        void Remove(int id);
        void Dispose();
    }
}
