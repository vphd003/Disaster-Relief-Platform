using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisasterRelief.API.Configurations
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouses");

            builder.HasKey(w => w.WarehouseId);

            builder.Property(w => w.WarehouseName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(w => w.Location)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(w => w.Capacity)
                .IsRequired();

            builder.Property(w => w.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasMany(w => w.Inventories)
                .WithOne(i => i.Warehouse)
                .HasForeignKey(i => i.WarehouseId);
        }
    }
}