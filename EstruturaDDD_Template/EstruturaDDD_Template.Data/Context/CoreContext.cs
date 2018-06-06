using EstruturaDDD_Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Data.Context
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
        //TODO tem no outro projeto
        //public CoreContext() : base()
        //{
        //}
        public virtual DbSet<Log> Logs { get; set; }
    }
}
