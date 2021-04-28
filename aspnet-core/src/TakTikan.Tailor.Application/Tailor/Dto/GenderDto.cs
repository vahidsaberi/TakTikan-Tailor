using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class GenderDto
    {
        public string Title { get; set; }

        public virtual ICollection<FabricType> FabricTypies { get; set; }
    }
}
