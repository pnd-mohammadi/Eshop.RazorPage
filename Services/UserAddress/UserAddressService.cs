using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.UserAddress;
using Eshop.RazorPage.Models.UserAddress.Commands;

namespace Eshop.RazorPage.Services.UserAddress
{
    public class UserAddressService : IUserAddressService
    {
        public Task<ApiResult> CreateUserAddress(CreateAddressCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DeleteAddress(long addressID)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditUserAddress(EditAddressCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<AddressDto> GetAddressById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDto>> GetUserAddress()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> SetActiveAddress(long addressId)
        {
            throw new NotImplementedException();
        }
    }
}
