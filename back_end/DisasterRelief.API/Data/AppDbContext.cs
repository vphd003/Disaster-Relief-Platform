using DisasterRelief.API.Configurations;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        #region DbSet

        public DbSet<Role> Roles => Set<Role>();

        public DbSet<User> Users => Set<User>();

        public DbSet<Volunteer> Volunteers => Set<Volunteer>();

        public DbSet<Skill> Skills => Set<Skill>();

        public DbSet<VolunteerSkill> VolunteerSkills => Set<VolunteerSkill>();

        public DbSet<Requester> Requesters => Set<Requester>();

        public DbSet<ReliefRequest> ReliefRequests => Set<ReliefRequest>();

        public DbSet<Assignment> Assignments => Set<Assignment>();

        public DbSet<Notification> Notifications => Set<Notification>();

        public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        public DbSet<Supply> Supplies => Set<Supply>();

        public DbSet<RequestSupply> RequestSupplies => Set<RequestSupply>();

        public DbSet<Warehouse> Warehouses => Set<Warehouse>();

        public DbSet<Inventory> Inventories => Set<Inventory>();

        public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        }
    }
}