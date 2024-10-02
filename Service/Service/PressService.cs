using AutoMapper;
using BusinessObject;
using Repository.UnitOfWork;
using Service.DTO;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class PressService : IPressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PressService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Press?> Create(PressRequest request)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(request.CategoryId);
                if (category != null)
                {
                    var newPress = _mapper.Map<Press>(request);
                    var result = await _unitOfWork.PressRepository.CreateAsync(newPress);
                    if (result > 0)
                    {
                        return newPress;
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

        public async Task<Press?> DeleteById(int id)
        {
            try
            {
                var press = await _unitOfWork.PressRepository.GetByIdAsync(id);
                if (press != null) {
                    var result = await _unitOfWork.PressRepository.RemoveAsync(press);
                    if (result)
                    {
                        return press;
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

        public async Task<IEnumerable<Press>?> GetAll()
        {
            try
            {
                var list = await _unitOfWork.PressRepository.GetAllAsync();
                if(list != null)
                {
                    return list;
                }
                return new List<Press>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Press>();
            }
        }

        public async Task<Press?> GetById(int id)
        {
            try
            {
                var press = await _unitOfWork.PressRepository.GetByIdAsync(id);
                if (press != null) {
                    return press;
                }
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Press?> Update(int id, PressRequest request)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(request.CategoryId);
                var press = await _unitOfWork.PressRepository.GetByIdAsync(id);
                if (press != null && category != null)
                {
                    var updatedPress = _mapper.Map(request, press);
                    var result = await _unitOfWork.PressRepository.UpdateAsync(updatedPress);
                    if (result > 0)
                    {
                        return press;
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
