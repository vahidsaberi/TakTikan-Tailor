using Abp.IdentityServer4vNext;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TakTikan.Tailor.Authorization.Delegation;
using TakTikan.Tailor.Authorization.Roles;
using TakTikan.Tailor.Authorization.Users;
using TakTikan.Tailor.Chat;
using TakTikan.Tailor.Editions;
using TakTikan.Tailor.Friendships;
using TakTikan.Tailor.MultiTenancy;
using TakTikan.Tailor.MultiTenancy.Accounting;
using TakTikan.Tailor.MultiTenancy.Payments;
using TakTikan.Tailor.Storage;

namespace TakTikan.Tailor.EntityFrameworkCore
{
    public class TailorDbContext : AbpZeroDbContext<Tenant, Role, User, TailorDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public virtual DbSet<FabricCut> FabricCuts { get; set; }
        public virtual DbSet<FabricMaterial> FabricMaterials { get; set; }
        public virtual DbSet<FabricRoll> FabricRolls { get; set; }
        public virtual DbSet<FabricType> FabricTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<SalineStone> SalineStones { get; set; }
        public virtual DbSet<SalineStoneOrder> SalineStoneOrders { get; set; }
        public virtual DbSet<SalineStoneOrderItem> SalineStoneOrderItems { get; set; }
        public virtual DbSet<Seamstress> Seamstresses { get; set; }
        public virtual DbSet<SewnPiece> SewnPieces { get; set; }

        public TailorDbContext(DbContextOptions<TailorDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
