namespace TakTikan.Tailor.Dto
{
    public class SalineStoneOrderItemDto
    {
        public SalineStoneOrder SalineStoneOrder { get; set; }
        public SewnPiece SewnPiece { get; set; }
        public int NumberSent { get; set; }
        public int NumberReceived { get; set; }
        public int NumberStoke { get; set; }
    }
}
