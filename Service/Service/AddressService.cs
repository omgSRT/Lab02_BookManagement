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

        public async Task<Address?> Create(AddressRequest request)
        {
            try
            {
                var newAddress = _mapper.Map<Address>(request);
                var result = await _unitOfWork.AddressRepository.CreateAsync(newAddress);
                if (result > 0)
                {
                    return newAddress;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Address?> DeleteById(int id)
        {
            try
            {
                var address = await _unitOfWork.AddressRepository.GetByIdAsync(id);
                if (address != null)
                {
                    var result = await _unitOfWork.AddressRepository.RemoveAsync(address);
                    if(result)
                    {
                        return address;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Address>?> GetAll()
        {
            try
            {
                var list = await _unitOfWork.AddressRepository.GetAllAsync();
                if(list != null)
                {
                    return list;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Address?> GetById(int id)
        {
            try
            {
                var list = await _unitOfWork.AddressRepository.GetByIdAsync(id);
                if (list != null)
                {
                    return list;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Address?> Update(int id, AddressRequest request)
        {
            try
            {
                var address = await _unitOfWork.AddressRepository.GetByIdAsync(id);
                if (address != null)
                {
                    var updatedAddress = _mapper.Map(request, address);
                    var result = await _unitOfWork.AddressRepository.UpdateAsync(updatedAddress);
                    if(result > 0)
                    {
                        return updatedAddress;
                    }

                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
