using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace TakTikan.Tailor
{
    // برش های پارچه
    public class FabricCut : Entity, IFullAudited, IPassivable
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<SewnPiece> SewnPieces { get; set; }

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
