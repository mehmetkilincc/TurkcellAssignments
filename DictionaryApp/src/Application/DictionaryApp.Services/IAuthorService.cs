using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDisplayResponse>> GetAuthorDisplayResponseAsync();
        IEnumerable<AuthorDisplayResponse> GetAuthorDisplayResponses();
        Task CreateNewAuthorAsync(CreateNewAuthorRequest createNewAuthorRequest);
    }
}
