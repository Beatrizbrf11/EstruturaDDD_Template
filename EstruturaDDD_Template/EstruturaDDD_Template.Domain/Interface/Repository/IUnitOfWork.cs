using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Repository
{

    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Log,LogDTO> LogRepository { get; }
        //IRepository<Log> LogRepository2 { get; }
        void Commit();
    }
}
