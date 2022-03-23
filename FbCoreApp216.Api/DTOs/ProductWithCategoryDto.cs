namespace FbCoreApp216.Api.DTOs
{
    public class ProductWithCategoryDto: ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
