namespace FbCoreApp216.Api.DTOs
{
    public class CategoryWtihProductDto :CategoryDto
    {

        public IEnumerable<ProductDto> Products { get; set; }
    }
}
