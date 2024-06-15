using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Products;
using Eshop.RazorPage.Models.Products.Commands;

namespace Eshop.RazorPage.Services.Products
{
    public interface IProductService
    {
        Task<ApiResult> AddImageProduct(AddProductImageCommand command);
        Task<ApiResult> CreateImageProduct(CreateProductCommand command);
        Task<ApiResult> EditProduct(EditProductCommand command);
        Task<ApiResult> DeleteProduct(DeleteProductImgeCommand command);

        Task<ProductDto> GetProductById(long productId);
        Task<ProductDto> GetProductBySlug(string slug);
        Task<SingleProductDto?> GetSingleProduct(string slug);
        Task<ProductFilterResult> GetProductByFilter(ProductFilterParams filterparams);
        Task<ProductShopResult> GetProductForShop(ProductShopFilterParam filterParams);


    }
}
