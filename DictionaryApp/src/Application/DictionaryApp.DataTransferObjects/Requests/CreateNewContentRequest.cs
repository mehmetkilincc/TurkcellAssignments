using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Requests
{
    public class CreateNewContentRequest
    {
        [Required(ErrorMessage = "Başlık boş bırakılamaz!")]
        [MinLength(3, ErrorMessage = "Başlık minimum 3 Karakter olmalıdır!")]
        [MaxLength(75, ErrorMessage = "Başlık Maximum 75 Karakter Olabilir!")]
        public string Title { get; set; }
        [Required(ErrorMessage ="İçerik boş bırakılamaz!")]
        public string Body { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
    }
}
