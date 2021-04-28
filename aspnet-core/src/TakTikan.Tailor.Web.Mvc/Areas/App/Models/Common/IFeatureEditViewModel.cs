using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TakTikan.Tailor.Editions.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}