using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Editions.Dto;

namespace TakTikan.Tailor.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}