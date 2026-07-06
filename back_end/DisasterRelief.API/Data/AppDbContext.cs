using DisasterRelief.API.Configurations;
using DisasterRelief.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    #region DbSets

    public DbSet<Role> Roles => Set<Role>();

    public DbSet<User> Users => Set<User>();

    public DbSet<Volunteer> Volunteers => Set<Volunteer>();

    public DbSet<Requester> Requesters => Set<Requester>();

    public DbSet<Skill> Skills => Set<Skill>();

    public DbSet<VolunteerSkill> VolunteerSkills => Set<VolunteerSkill>();

    public DbSet<ReliefRequest> ReliefRequests => Set<ReliefRequest>();

    public DbSet<RequestSupply> RequestSupplies => Set<RequestSupply>();

    public DbSet<Assignment> Assignments => Set<Assignment>();

    public DbSet<Warehouse> Warehouses => Set<Warehouse>();

    public DbSet<Supply> Supplies => Set<Supply>();

    public DbSet<Inventory> Inventories => Set<Inventory>();

    public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

    public DbSet<Notification> Notifications => Set<Notification>();

    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all Fluent API configurations automatically
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}