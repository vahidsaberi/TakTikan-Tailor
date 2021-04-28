using Abp.AutoMapper;
using TakTikan.Tailor.Authorization.Roles.Dto;
using TakTikan.Tailor.Web.Areas.App.Models.Common;

namespace TakTikan.Tailor.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}