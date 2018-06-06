using AutoMapper;
using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaDDD_Template.Aplication.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<LogDTO, LogViewModel>()
                .ReverseMap();
                //.ForMember(dto => dto.CreatedAt, opt => opt.Ignore());
        }
    }
}
