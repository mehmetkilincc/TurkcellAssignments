using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Responses
{
    public class AuthorDisplayResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageUrl { get; set; } = "https://picsum.photos/75/50";
    }
}
