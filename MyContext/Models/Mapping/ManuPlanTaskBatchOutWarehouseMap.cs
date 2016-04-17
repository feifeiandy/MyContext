using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class ManuPlanTaskBatchOutWarehouseMap : EntityTypeConfiguration<ManuPlanTaskBatchOutWarehouse>
    {
        public ManuPlanTaskBatchOutWarehouseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ManuPlanTaskBatchOutWarehouse");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ManuPlanTaskBatchId).HasColumnName("ManuPlanTaskBatchId");
            this.Property(t => t.Seq).HasColumnName("Seq");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.PlanAmount).HasColumnName("PlanAmount");

            // Relationships
            this.HasRequired(t => t.ManuPlanTaskBatch)
                .WithMany(t => t.ManuPlanTaskBatchOutWarehouses)
                .HasForeignKey(d => d.ManuPlanTaskBatchId);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.ManuPlanTaskBatchOutWarehouses)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.ManuPlanTaskBatchOutWarehouses)
                .HasForeignKey(d => d.AllocationCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.ManuPlanTaskBatchOutWarehouses)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
