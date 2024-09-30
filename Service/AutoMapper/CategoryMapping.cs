using AutoMapper;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping() {
            CreateMap<Category, CategoryMapping>().ReverseMap()
                .ForMember(dest => dest.Presses, opt => opt.Ignore());
        }
    }
}
