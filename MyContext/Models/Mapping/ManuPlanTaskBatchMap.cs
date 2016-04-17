using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class ManuPlanTaskBatchMap : EntityTypeConfiguration<ManuPlanTaskBatch>
    {
        public ManuPlanTaskBatchMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ManuPlanTaskNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BorLineCode)
                .HasMaxLength(50);

            this.Property(t => t.BorSectionCode)
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("ManuPlanTaskBatch");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ManuPlanTaskNumber).HasColumnName("ManuPlanTaskNumber");
            this.Property(t => t.Seq).HasColumnName("Seq");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.FinishTime).HasColumnName("FinishTime");
            this.Property(t => t.PlanQuantity).HasColumnName("PlanQuantity");
            this.Property(t => t.BatchQuantity).HasColumnName("BatchQuantity");
            this.Property(t => t.BorLineCode).HasColumnName("BorLineCode");
            this.Property(t => t.BorSectionCode).HasColumnName("BorSectionCode");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.SyncStatus).HasColumnName("SyncStatus");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasRequired(t => t.ManuPlanTask)
                .WithMany(t => t.ManuPlanTaskBatches)
                .HasForeignKey(d => d.ManuPlanTaskNumber);

        }
    }
}
