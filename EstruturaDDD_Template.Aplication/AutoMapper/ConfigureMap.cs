using AutoMapper;
using EntruturaDDD_Template.Cross.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaDDD_Template.Aplication.AutoMapper
{
    public static class ConfigureMap
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DataMappingProfile>();
                cfg.AddProfile<WebMappingProfile>();
            });
        }
    }
}
