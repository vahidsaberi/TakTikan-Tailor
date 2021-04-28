using System.Collections.Generic;
using TakTikan.Tailor.Caching.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}