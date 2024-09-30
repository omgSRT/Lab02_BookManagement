using AutoMapper;
using BusinessObject;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper
{
    public class PressMapping : Profile
    {
        public PressMapping() {
            CreateMap<Press, PressRequest>().ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore())
                .ForMember(dest => dest.Books, opt => opt.Ignore());
        }
    }
}
