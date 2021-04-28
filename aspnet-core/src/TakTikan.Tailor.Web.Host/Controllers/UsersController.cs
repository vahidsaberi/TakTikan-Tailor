using Abp.AspNetCore.Mvc.Authorization;
using TakTikan.Tailor.Authorization;
using TakTikan.Tailor.Storage;
using Abp.BackgroundJobs;

namespace TakTikan.Tailor.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}