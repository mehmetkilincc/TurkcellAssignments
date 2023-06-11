using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDisplayResponse>> GetCategoryDisplayResponseAsync();
        IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses();
        Task CreateNewCategoryAsync(CreateNewCategoryRequest createNewCategoryRequest);
        Task<CategoryDisplayResponse> GetCategoryByIdAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryRequest updateCategoryRequest);
        Task<UpdateCategoryRequest> GetCategoryForUpdateAsync(int id);
        Task DeleteCategoryAsync(int id);
        Task<bool> CategoryIsExistAsync(int id);
    }
}
