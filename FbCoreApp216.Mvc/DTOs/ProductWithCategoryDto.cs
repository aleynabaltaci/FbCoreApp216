namespace FbCoreApp216.Mvc.DTOs
{
    public class ProductWithCategoryDto: ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
