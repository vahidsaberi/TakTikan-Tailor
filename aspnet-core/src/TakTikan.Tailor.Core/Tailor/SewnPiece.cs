using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace TakTikan.Tailor
{
    //  تکه های دوخته شده
    public class SewnPiece : Entity, IFullAudited, IPassivable
    {
        public DateTime DoneDateEn { get; set; }
        public string DoneDateFa { get; set; }

        public Seamstress Seamstress { get; set; }
        public FabricRoll FabricRoll { get; set; }
        public FabricCut FabricCut { get; set; }
        public int Count { get; set; }

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
