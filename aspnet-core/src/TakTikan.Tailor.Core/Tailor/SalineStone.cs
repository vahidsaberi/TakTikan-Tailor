using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace TakTikan.Tailor
{
    //  سنگشور
    public class SalineStone : Entity, IFullAudited, IPassivable
    {
        public int Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<SalineStoneOrder> SalineStoneOrders { get; set; }

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
