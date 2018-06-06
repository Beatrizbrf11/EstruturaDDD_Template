using EstruturaDDD_Template.Data.Context;
using EstruturaDDD_Template.Data.Repository;
using EstruturaDDD_Template.Domain.Entities;
using EstruturaDDD_Template.Domain.Interface.Repository;
using EstruturaDDD_Template.Domain.Interface.Service;
using EstruturaDDD_Template.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using Remotion.Linq.Clauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Services
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<CoreContext>();
            #region Repository

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Log>, Repository<Log>>();

            #endregion

            #region Service

            services.AddScoped<ILogService, LogService>();

            #endregion
        }
    }
}
