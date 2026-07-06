using DisasterRelief.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisasterRelief.API.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.ToTable("AuditLogs");

            builder.HasKey(a => a.AuditId);

            builder.Property(a => a.Action)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Entity)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(a => a.User)
                .WithMany(u => u.AuditLogs)
                .HasForeignKey(a => a.UserId);
        }
    }
}