using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class ManuPlanTaskBatchTransDetailMap : EntityTypeConfiguration<ManuPlanTaskBatchTransDetail>
    {
        public ManuPlanTaskBatchTransDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ManuPlanTaskNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ManuPlanTaskBatchTransDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ManuPlanTaskNumber).HasColumnName("ManuPlanTaskNumber");
            this.Property(t => t.ManuPlanTaskBatchId).HasColumnName("ManuPlanTaskBatchId");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
            this.Property(t => t.TransCount).HasColumnName("TransCount");
            this.Property(t => t.TransTime).HasColumnName("TransTime");
            this.Property(t => t.SyncStatus).HasColumnName("SyncStatus");

            // Relationships
            this.HasRequired(t => t.ManuPlanTask)
                .WithMany(t => t.ManuPlanTaskBatchTransDetails)
                .HasForeignKey(d => d.ManuPlanTaskNumber);
            this.HasRequired(t => t.ManuPlanTaskBatch)
                .WithMany(t => t.ManuPlanTaskBatchTransDetails)
                .HasForeignKey(d => d.ManuPlanTaskBatchId);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.ManuPlanTaskBatchTransDetails)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.ManuPlanTaskBatchTransDetails)
                .HasForeignKey(d => d.AllocationCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.ManuPlanTaskBatchTransDetails)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
