using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace TakTikan.Tailor
{
    // سفارشات دست سنگشور ها
    public class SalineStoneOrder : Entity, IFullAudited, IPassivable
    {
        public SalineStone SalineStone { get; set; }

        public DateTime SendDateEn { get; set; }
        public string SendDateFa { get; set; }

        public DateTime ReceivedDateEn { get; set; }
        public string ReceivedDateFa { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal DeductedPrice { get; set; }

        public virtual ICollection<SalineStoneOrderItem> SalineStoneOrderItems { get; set; }

        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
