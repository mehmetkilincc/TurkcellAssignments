using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        // Navigation properties
        public ICollection<Content> Contents { get; set; }
    }
}
