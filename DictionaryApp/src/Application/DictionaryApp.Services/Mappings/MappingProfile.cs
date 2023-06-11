using AutoMapper;
using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.DataTransferObjects.Responses;
using DictionaryApp.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // For Category
            CreateMap<Category, CategoryDisplayResponse>();
            CreateMap<CreateNewCategoryRequest, Category>();
            CreateMap<UpdateCategoryRequest, Category>().ReverseMap();

            // For Author
            CreateMap<Author, AuthorDisplayResponse>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name + " " + src.Surname));
            CreateMap<CreateNewAuthorRequest, Author>();

            // For Content
            CreateMap<Content, ContentDisplayResponse>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName)); ;
            CreateMap<CreateNewContentRequest, Content>();
        }
    }
}
