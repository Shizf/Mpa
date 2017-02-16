using System.Threading.Tasks;
using Abp.Application.Services;
using Mpa.Roles.Dto;

namespace Mpa.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
