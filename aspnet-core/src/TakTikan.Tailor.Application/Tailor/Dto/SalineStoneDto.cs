using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class SalineStoneDto
    {
        public int Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<SalineStoneOrder> SalineStoneOrders { get; set; }
    }
}
