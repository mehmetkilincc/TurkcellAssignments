using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Entities
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string ImageUrl { get; set; } = "https://picsum.photos/75/50";

        // Navigation property
        public ICollection<Content> Contents { get; set; }
    }
}
