using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Data.Context;
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
        public CoreContext _context;

        private bool disposed = false;

        public UnitOfWork(CoreContext context)
        {
            _context = context;
        }
        
        private IBaseRepository<Log,LogDTO> logRepository;
        //private IRepository<Log> logRepository2;

        public IBaseRepository<Log, LogDTO> LogRepository
        {
            get
            {
                if (logRepository == null)
                    logRepository = new BaseRepository<Log, LogDTO>(_context);
                return logRepository;
            }
        }
        //TODO Apagar
        //public IRepository<Log> LogRepository2
        //{
        //    get
        //    {
        //        if (this.logRepository2 == null)
        //            this.logRepository2 = new Repository<Log>(_context);
        //        return logRepository2;
        //    }
        //}

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