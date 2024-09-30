using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper
{
    public class AddressMapping : Profile
    {
        public AddressMapping() { 
            CreateMap<Address, AddressRequest>().ReverseMap()
                .ForMember(dest => dest.Books, opt => opt.Ignore());
        }
    }
}
