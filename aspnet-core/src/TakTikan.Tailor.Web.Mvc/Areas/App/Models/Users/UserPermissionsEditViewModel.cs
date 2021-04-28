using Abp.AutoMapper;
using TakTikan.Tailor.Authorization.Users;
using TakTikan.Tailor.Authorization.Users.Dto;
using TakTikan.Tailor.Web.Areas.App.Models.Common;

namespace TakTikan.Tailor.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}