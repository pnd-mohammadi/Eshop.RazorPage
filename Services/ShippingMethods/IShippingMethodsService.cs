using Eshop.RazorPage.Models.ShippingMethods;

namespace Eshop.RazorPage.Services.ShippingMethods
{
    public interface IShippingMethodsService
    {
        Task<List<ShippingMethodDto>> GetShippingMethods();

    }
}
