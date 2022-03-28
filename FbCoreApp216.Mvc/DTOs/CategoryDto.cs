using System.ComponentModel.DataAnnotations;

namespace FbCoreApp216.Mvc.DTOs
{
    public class CategoryDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage="{0} alanı gereklidir.")]
        public string CategoryName { get; set; }
    }
}
