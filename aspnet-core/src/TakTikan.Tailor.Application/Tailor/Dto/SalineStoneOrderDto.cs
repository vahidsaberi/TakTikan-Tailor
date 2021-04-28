using System;
using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class SalineStoneOrderDto
    {
        public SalineStone SalineStone { get; set; }

        public DateTime SendDateEn { get; set; }
        public string SendDateFa { get; set; }

        public DateTime ReceivedDateEn { get; set; }
        public string ReceivedDateFa { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal DeductedPrice { get; set; }

        public virtual ICollection<SalineStoneOrderItem> SalineStoneOrderItems { get; set; }
    }
}
