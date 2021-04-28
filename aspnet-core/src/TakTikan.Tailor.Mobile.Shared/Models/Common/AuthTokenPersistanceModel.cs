using System;
using Abp.AutoMapper;
using TakTikan.Tailor.Sessions.Dto;

namespace TakTikan.Tailor.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}