using FbCoreApp216.Mvc.DTOs;

namespace FbCoreApp216.Mvc.DTOs
{
    public class CategoryWithProductDto :CategoryDto
    {

        public IEnumerable<ProductDto> Products { get; set; }
    }
}
