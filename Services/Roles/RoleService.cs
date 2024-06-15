using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Roles;

namespace Eshop.RazorPage.Services.Roles
{
    public class RoleService : IRoleService
    {
        public Task<ApiResult> CreateRole(CreateRoleCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditRole(EditRoleCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<RoleDto> GetRoleById(int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoleDto>> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
