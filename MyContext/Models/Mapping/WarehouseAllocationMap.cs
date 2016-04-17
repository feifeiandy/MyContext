using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseAllocationMap : EntityTypeConfiguration<WarehouseAllocation>
    {
        public WarehouseAllocationMap()
        {
            // Primary Key
            this.HasKey(t => t.AllocationCode);

            // Properties
            this.Property(t => t.AllocationCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseAllocation");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.NeedBatchManager).HasColumnName("NeedBatchManager");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseAllocations)
                .HasForeignKey(d => d.WarehouseCode);

        }
    }
}
