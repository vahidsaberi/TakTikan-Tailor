using System;

namespace TakTikan.Tailor.Dto
{
    public class SewnPieceDto
    {
        public DateTime DoneDateEn { get; set; }
        public string DoneDateFa { get; set; }

        public Seamstress Seamstress { get; set; }
        public FabricRoll FabricRoll { get; set; }
        public FabricCut FabricCut { get; set; }
        public int Count { get; set; }
    }
}
