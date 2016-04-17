using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseBatchMasterMap : EntityTypeConfiguration<WarehouseBatchMaster>
    {
        public WarehouseBatchMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseBatchMaster");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.FinishTime).HasColumnName("FinishTime");
            this.Property(t => t.Finished).HasColumnName("Finished");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseBatchMasters)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.WarehouseBatchMasters)
                .HasForeignKey(d => d.AllocationCode);

        }
    }
}
