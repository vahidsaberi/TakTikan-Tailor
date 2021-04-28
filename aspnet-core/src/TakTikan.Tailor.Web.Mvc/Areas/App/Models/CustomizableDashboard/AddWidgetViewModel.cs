using System.Collections.Generic;
using TakTikan.Tailor.DashboardCustomization.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
