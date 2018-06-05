using EstruturaDDD_Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Data.Content
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        {

        }

        public virtual DbSet<Log> Logs { get; set; }
    }
}
