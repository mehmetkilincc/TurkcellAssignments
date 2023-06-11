using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Requests
{
    public class CreateNewAuthorRequest
    {
        [Required(ErrorMessage ="Yazar adı boş geçilemez.")]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yazar soyadı boş geçilemez.")]
        [MaxLength(25)]
        public string Surname { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? ImageUrl { get; set; } = "https://picsum.photos/75/50";
    }
}
