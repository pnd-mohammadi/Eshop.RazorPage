using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.UserAddress;
using Eshop.RazorPage.Models.UserAddress.Commands;

namespace Eshop.RazorPage.Services.UserAddress;

public interface IUserAddressService
{
    Task<ApiResult> CreateUserAddress(CreateAddressCommand command);
    Task<ApiResult> EditUserAddress(EditAddressCommand command);
    Task<ApiResult> DeleteAddress(long addressID);
    Task<ApiResult> SetActiveAddress(long addressId);
    Task<AddressDto> GetAddressById(long id);
    Task<List<AddressDto>> GetUserAddress();
}
