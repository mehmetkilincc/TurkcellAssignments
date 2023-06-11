using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Responses
{
    public class ContentDisplayResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string? AuthorName { get; set; }
        public string? CategoryName { get; set; }
    }
}
