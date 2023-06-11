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
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task CreateNewAuthorAsync(CreateNewAuthorRequest createNewAuthorRequest)
        {
            var author = createNewAuthorRequest.MapTo<CreateNewAuthorRequest, Author>(_mapper);
            await _authorRepository.AddAsync(author);
        }

        public async Task<IEnumerable<AuthorDisplayResponse>> GetAuthorDisplayResponseAsync()
        {
            var response  = await _authorRepository.GetAllAsync();
            return response.MapTo<IEnumerable<Author>, IEnumerable<AuthorDisplayResponse>>(_mapper);
        }

        public IEnumerable<AuthorDisplayResponse> GetAuthorDisplayResponses()
        {
            var response = _authorRepository.GetAll();
            return response.MapTo<IEnumerable<Author>,IEnumerable<AuthorDisplayResponse>>(_mapper);
        }
    }
}
