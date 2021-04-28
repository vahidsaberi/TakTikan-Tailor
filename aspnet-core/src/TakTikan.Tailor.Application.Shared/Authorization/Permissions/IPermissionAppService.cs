using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Authorization.Permissions.Dto;

namespace TakTikan.Tailor.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
