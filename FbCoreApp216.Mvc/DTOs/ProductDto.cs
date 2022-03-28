using System.ComponentModel.DataAnnotations;

namespace FbCoreApp216.Mvc.DTOs
{
    public class ProductDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        public string ProductName { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="{0} alanı sıfırdan büyük bir değer olmalıdır.")]
        public int Stock { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "{0} alanı sıfırdan büyük bir değer olmalıdır.")]
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
}
