using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Entities
{
    public class Content : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }

        // Navigation properties
        public Author? Author { get; set; }
        public Category? Category { get; set; }
    }
}
