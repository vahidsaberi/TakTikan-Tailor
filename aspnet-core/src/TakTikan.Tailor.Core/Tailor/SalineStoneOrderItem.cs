using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace TakTikan.Tailor
{
    // تکه های دوخته شده درون سفارش سنگشور
    public class SalineStoneOrderItem : Entity, IFullAudited, IPassivable
    {
        public SalineStoneOrder SalineStoneOrder { get; set; }
        public SewnPiece SewnPiece { get; set; }
        public int NumberSent { get; set; }
        public int NumberReceived { get; set; }
        public int NumberStoke { get; set; }

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
