using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.Localization;
using Abp.Runtime.Validation;

namespace TakTikan.Tailor.Dto
{
    public class GenderInput : IPagedResultRequest, ISortedResultRequest, IShouldNormalize
    {
        [Range(0, int.MaxValue)]
        public int MaxResultCount { get; set; } //0: Unlimited.

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public string Sorting { get; set; }

        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength, MinimumLength = 2)]
        public string TargetGenderName { get; set; }

        public string TargetValueFilter { get; set; }

        public string FilterText { get; set; }

        public void Normalize()
        {
            if (TargetValueFilter.IsNullOrEmpty())
            {
                TargetValueFilter = "ALL";
            }
        }
    }
}
