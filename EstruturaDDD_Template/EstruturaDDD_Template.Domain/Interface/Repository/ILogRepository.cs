using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Repository
{
    public interface ILogRepository : IBaseRepository<Log, LogDTO>
    {
    }
}
