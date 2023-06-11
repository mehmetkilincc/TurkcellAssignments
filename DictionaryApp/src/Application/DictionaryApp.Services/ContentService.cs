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
    public class ContentService : IContentService
    {
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;

        public ContentService(IContentRepository contentRepository, IMapper mapper)
        {
            _contentRepository = contentRepository;
            _mapper = mapper;
        }

        public async Task CreateNewContentAsync(CreateNewContentRequest createNewContentRequest)
        {
            var content = createNewContentRequest.MapTo<CreateNewContentRequest, Content>(_mapper);
            await _contentRepository.AddAsync(content);
        }

        public async Task<IEnumerable<ContentDisplayResponse>> GetContentDisplayResponseAsync()
        {
            var response = await _contentRepository.GetAllAsync();
            return response.MapTo<IEnumerable<Content>,IEnumerable<ContentDisplayResponse>>(_mapper);
        }

        public IEnumerable<ContentDisplayResponse> GetContentDisplayResponses()
        {
            var response = _contentRepository.GetAll();
            return response.MapTo<IEnumerable<Content>, IEnumerable<ContentDisplayResponse>>(_mapper);
        }
    }
}
