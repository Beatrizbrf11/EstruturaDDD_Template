using AutoMapper;
using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Domain.Entities;
using System;

namespace EntruturaDDD_Template.Cross.AutoMapper
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<Log, LogDTO>().ReverseMap();
        }
    }
}
