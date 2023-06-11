using AutoMapper;
using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.DataTransferObjects.Responses;
using DictionaryApp.Entities;
using DictionaryApp.Infrastructure.Repositories;
using DictionaryApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> CategoryIsExistAsync(int id)
        {
            return await _categoryRepository.IsExistAsync(id);
        }

        public async Task CreateNewCategoryAsync(CreateNewCategoryRequest createNewCategoryRequest)
        {
            var category = createNewCategoryRequest.MapTo<CreateNewCategoryRequest, Category>(_mapper);
            await _categoryRepository.AddAsync(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<CategoryDisplayResponse> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            return category.MapTo<Category, CategoryDisplayResponse>(_mapper);
        }

        public async Task<IEnumerable<CategoryDisplayResponse>> GetCategoryDisplayResponseAsync()
        {
            var response = await _categoryRepository.GetAllAsync();
            return response.MapTo<IEnumerable<Category>, IEnumerable<CategoryDisplayResponse>>(_mapper);
        }

        public IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses()
        {
            var response = _categoryRepository.GetAll();
            return response.MapTo<IEnumerable<Category>, IEnumerable<CategoryDisplayResponse>>(_mapper);
        }

        public async Task<UpdateCategoryRequest> GetCategoryForUpdateAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            return category.MapTo<Category, UpdateCategoryRequest>(_mapper);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            var category = updateCategoryRequest.MapTo<UpdateCategoryRequest, Category>(_mapper);
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
