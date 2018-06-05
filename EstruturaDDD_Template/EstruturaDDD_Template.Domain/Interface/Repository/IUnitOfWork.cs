using EstruturaDDD_Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Interface.Repository
{

    public interface IUnitOfWork : IDisposable
    {

        IRepository<Log> LogRepository { get; }
        void Commit();
    }
}
