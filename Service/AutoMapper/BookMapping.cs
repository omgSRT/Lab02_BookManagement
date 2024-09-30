using AutoMapper;
using BusinessObject.DTO;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO;

namespace Service.AutoMapper
{
    public class BookMapping : Profile
    {
        public BookMapping() {
            CreateMap<Book, BookRequest>().ReverseMap()
                .ForMember(dest => dest.Address, opt => opt.Ignore())
                .ForMember(dest => dest.Press, opt => opt.Ignore());
        }
    }
}
