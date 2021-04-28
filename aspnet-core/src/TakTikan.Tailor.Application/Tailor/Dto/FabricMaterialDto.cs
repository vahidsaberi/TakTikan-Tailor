using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class FabricMaterialDto
    {
        public string Title { get; set; }

        public virtual ICollection<FabricType> FabricTypies { get; set; }
    }
}
