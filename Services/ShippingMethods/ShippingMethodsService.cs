using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.ShippingMethods;

namespace Eshop.RazorPage.Services.ShippingMethods
{
    public class ShippingMethodsService : IShippingMethodsService
    {
        private readonly HttpClient _client;
        private const string ModuleName = "ShippingMethod";

        public ShippingMethodsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ShippingMethodDto>> GetShippingMethods()
        {
            var result = await _client.GetFromJsonAsync<ApiResult<List<ShippingMethodDto>>>($"{ModuleName}");
            return result?.Data ?? new();
        }
    }
}
