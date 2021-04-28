using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Configuration.Host.Dto;
using TakTikan.Tailor.Editions.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}