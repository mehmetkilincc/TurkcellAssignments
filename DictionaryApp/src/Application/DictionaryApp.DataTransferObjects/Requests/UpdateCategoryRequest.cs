using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Requests
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kategori Adı Boş Bırakılamaz!")]
        [MinLength(3, ErrorMessage = "Kategori Adı minimum 3 Karakter olmalıdır!")]
        [MaxLength(30, ErrorMessage = "Kategori Adı Maximum 30 Karakter Olabilir!")]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
