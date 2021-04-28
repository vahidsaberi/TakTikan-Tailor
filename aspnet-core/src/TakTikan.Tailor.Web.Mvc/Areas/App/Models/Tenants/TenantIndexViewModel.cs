using System.Collections.Generic;
using TakTikan.Tailor.Editions.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}