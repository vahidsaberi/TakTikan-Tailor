using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Authorization;
using TakTikan.Tailor.DashboardCustomization;
using System.Threading.Tasks;
using TakTikan.Tailor.Web.Areas.App.Startup;

namespace TakTikan.Tailor.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(TailorDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}