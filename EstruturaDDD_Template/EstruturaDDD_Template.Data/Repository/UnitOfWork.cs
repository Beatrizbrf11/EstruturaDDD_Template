using EstruturaDDD_Template.Data.Content;
using EstruturaDDD_Template.Data.Repository;
using EstruturaDDD_Template.Domain.Entities;
using EstruturaDDD_Template.Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppContexto _context;

        private bool disposed = false;

        public UnitOfWork(AppContexto context)
        {
            _context = context;
        }
        
        private IRepository<Log> logRepository;

        public IRepository<Log> LogRepository
        {
            get
            {
                if (this.logRepository == null)
                    this.logRepository = new Repository<Log>(_context);
                return logRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}