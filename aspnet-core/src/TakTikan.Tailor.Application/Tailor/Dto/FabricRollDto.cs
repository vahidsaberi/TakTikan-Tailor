using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class FabricRollDto
    {
        public string Code { get; set; }
        public FabricType FabricType { get; set; }
        public int Count { get; set; }

        public virtual ICollection<SewnPiece> SewnPieces { get; set; }
    }
}
