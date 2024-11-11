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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Category?> Create(CategoryRequest request)
        {
            try
            {
                var newCategory = _mapper.Map<Category>(request);
                var result = await _unitOfWork.CategoryRepository.CreateAsync(newCategory);
                if(result > 0)
                {
                    return newCategory;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Category?> DeleteById(int id)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
                if (category != null)
                {
                    var result = await _unitOfWork.CategoryRepository.RemoveAsync(category);
                    if(result)
                    {
                        return category;
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

        public async Task<IEnumerable<Category>?> GetAll()
        {
            try
            {
                var list = await _unitOfWork.CategoryRepository.GetAllAsync();
                if(list != null)
                {
                    return list;
                }
                return new List<Category>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Category>();
            }
        }

        public async Task<IEnumerable<Category>> GetAllWithInclude(string include)
        {
            try
            {
                var list = await _unitOfWork.CategoryRepository.GetAllWithInclude(include);
                if (list != null)
                {
                    return list;
                }
                return new List<Category>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Category>();
            }
        }
        public async Task<IEnumerable<Category>> GetAllWith2Include(string include1, string include2)
        {
            try
            {
                var list = await _unitOfWork.CategoryRepository.GetAllWith2Include(include1, include2);
                if (list != null)
                {
                    return list;
                }
                return new List<Category>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Category>();
            }
        }

        public async Task<Category?> GetById(int id)
        {
            var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
            if(category != null)
            {
                return category;
            }
            return null;
        }

        public async Task<Category?> Update(int id, CategoryRequest request)
        {
            try
            {
                var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
                if (category != null)
                {
                    var updatedCategory = _mapper.Map(request, category);
                    var result = await _unitOfWork.CategoryRepository.UpdateAsync(updatedCategory);
                    if(result > 0)
                    {
                        return updatedCategory;
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
