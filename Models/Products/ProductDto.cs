using Eshop.RazorPage.Models.Categories;
using Eshop.RazorPage.Models.Sellers;

namespace Eshop.RazorPage.Models.Products;

public class ProductDto :BaseDto
{
    public string Title { get; set; }
    public string ImageName { get; set; }
    public string Description { get; set; }
    public ProductCategoryDto Category { get; set; }
    public ProductCategoryDto SubCategory { get; set; }
    public ProductCategoryDto? SecondarySubCategory { get; set; }
    public string Slug { get; set; }
    public SeoData SeoData { get; set; }
    public List<ProductImageDto> Images { get; set; }
    public List<ProductSpecificationDto> Specifications { get; set; }

}
public class ProductCategoryDto
{
    public long Id { get; set; }
    public long? ParentId { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public SeoData SeoData { get; set; }
}
public class ProductFilterData : BaseDto
{
    public string Title { get; set; }
    public string ImageName { get; set; }
    public string Slug { get; set; }
}
public class ProductFilterParams : BaseFilterParam
{
    public string? Title { get; set; }
    public long? Id { get; set; }
    public string? Slug { get; set; }
}
public class ProductFilterResult : BaseFilter<ProductFilterData, ProductFilterParams>
{

}
public class ProductImageDto : BaseDto
{
    public long ProductId { get; set; }
    public string ImageName { get; set; }
    public int Sequence { get; set; }
}

public class ProductShopResult : BaseFilter<ProductShopDto, ProductShopFilterParam>
{
    public CategoryDto? CategoryDto { get; set; }
}

public class ProductShopDto : BaseDto
{
    public string Title { get; set; }
    public string Slug { get; set; }
    public long InventoryId { get; set; }
    public int Price { get; set; }
    public int DiscountPercentage { get; set; }
    public string ImageName { get; set; }

    public int TotalPrice
    {
        get
        {
            var discount = Price * DiscountPercentage / 100;
            return Price - discount;
        }
    }
}
public class ProductShopFilterParam : BaseFilterParam
{
    public string? CategorySlug { get; set; } = "";
    public string? Search { get; set; } = "";
    public bool OnlyAvailableProducts { get; set; } = false;
    public bool JustHasDiscount { get; set; } = false;
    public ProductSearchOrderBy SearchOrderBy { get; set; } = ProductSearchOrderBy.Cheapest;
}

public enum ProductSearchOrderBy
{
    Latest,
    Expensive,
    Cheapest,
}

public class ProductSpecificationDto
{
    public string Key { get; set; }
    public string Value { get; set; }
}

public class SingleProductDto
{
    public ProductDto ProductDto { get; set; }
    public List<InventoryDto> Inventories { get; set; }
}