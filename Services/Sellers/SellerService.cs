using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Sellers;
using Eshop.RazorPage.Models.Sellers.Commands;

namespace Eshop.RazorPage.Services.Sellers
{
    public class SellerService : ISellerService
    {
        private readonly HttpClient _client;
        private  const string ModuleName = "Seller";
        public SellerService(HttpClient client)
        {
            _client = client;
        }

        public Task<ApiResult> AddInventory(AddSellerInventoryCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> CreateSeller(CreateSellerCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditInventory(EditSellerInventoryCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditSeller(EditSellerCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<SellerDto?> GetCurrentSeller()
        {
            throw new NotImplementedException();
        }

        public Task<InventoryDto> GetInventoryById(long inventoryId)
        {
            throw new NotImplementedException();
        }

        public Task<SellerFilterResult> GetSellerByFilter(SellerFilterParams filterParams)
        {
            throw new NotImplementedException();
        }

        public Task<SellerDto> GetSellerById(long sellerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryDto>> GetSellerInventories()
        {
            throw new NotImplementedException();
        }
    }
}
