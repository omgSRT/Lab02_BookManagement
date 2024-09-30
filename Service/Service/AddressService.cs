using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using Microsoft.Extensions.Logging;
using Repository.UnitOfWork;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddressService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Address>? Create(AddressRequest request)
        {
            try
            {
                var newAddress = _mapper.Map<Address>(request);
                var result = await _unitOfWork.AddressRepository.CreateAsync(newAddress);
                if (result > 0)
                {
                    return newAddress;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<Address> DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<Address> Update(long id, AddressRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
