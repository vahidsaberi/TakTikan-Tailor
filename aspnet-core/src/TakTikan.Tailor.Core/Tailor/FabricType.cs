using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace TakTikan.Tailor
{
    //  نوع پارچه ها
    public class FabricType : Entity, IFullAudited, IPassivable
    {
        public string Title { get; set; }
        public FabricMaterial FabricMaterial { get; set; }
        public Gender Gender { get; set; }
        public string Color { get; set; }
        public string Factory { get; set; }

        public virtual ICollection<FabricRoll> FabricRolles { get; set; }

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
