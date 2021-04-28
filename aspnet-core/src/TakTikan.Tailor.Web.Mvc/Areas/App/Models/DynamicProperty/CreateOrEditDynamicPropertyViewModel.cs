using System.Collections.Generic;
using TakTikan.Tailor.DynamicEntityProperties.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
