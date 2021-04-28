using System.Collections.Generic;
using Abp.Localization;
using TakTikan.Tailor.Install.Dto;

namespace TakTikan.Tailor.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
