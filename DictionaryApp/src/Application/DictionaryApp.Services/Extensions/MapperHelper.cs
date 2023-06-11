using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services.Extensions
{
    public static class MapperHelper
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source, IMapper mapper)
        {
            return mapper.Map<TSource, TDestination>(source);
        }
    }
}
