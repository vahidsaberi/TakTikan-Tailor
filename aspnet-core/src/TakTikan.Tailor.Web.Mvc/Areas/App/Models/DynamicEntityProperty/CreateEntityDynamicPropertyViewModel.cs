﻿using System.Collections.Generic;
using TakTikan.Tailor.DynamicEntityProperties.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
