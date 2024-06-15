using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Products;
using Eshop.RazorPage.Models.Products.Commands;

namespace Eshop.RazorPage.Services.Products
{
    public class ProductService : IProductService
    {
        public Task<ApiResult> AddImageProduct(AddProductImageCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> CreateImageProduct(CreateProductCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DeleteProduct(DeleteProductImgeCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditProduct(EditProductCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFilterResult> GetProductByFilter(ProductFilterParams filterparams)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductById(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductBySlug(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<ProductShopResult> GetProductForShop(ProductShopFilterParam filterParams)
        {
            throw new NotImplementedException();
        }

        public Task<SingleProductDto?> GetSingleProduct(string slug)
        {
            throw new NotImplementedException();
        }
    }
}
