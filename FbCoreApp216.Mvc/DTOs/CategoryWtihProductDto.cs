using FbCoreApp216.Api.DTOs;

namespace FbCoreApp216.Mvc.DTOs
{
    public class CategoryWtihProductDto :CategoryDto
    {

        public IEnumerable<ProductDto> Products { get; set; }
    }
}
