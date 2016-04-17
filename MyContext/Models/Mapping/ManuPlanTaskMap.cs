using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class ManuPlanTaskMap : EntityTypeConfiguration<ManuPlanTask>
    {
        public ManuPlanTaskMap()
        {
            // Primary Key
            this.HasKey(t => t.ManuPlanTaskNumber);

            // Properties
            this.Property(t => t.ManuPlanTaskNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlanTaskTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BomCode)
                .HasMaxLength(50);

            this.Property(t => t.BorLineCode)
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUserName)
                .HasMaxLength(50);

            this.Property(t => t.ReleaseUser)
                .HasMaxLength(50);

            this.Property(t => t.ReleaseUserName)
                .HasMaxLength(50);

            this.Property(t => t.AbolishUser)
                .HasMaxLength(10);

            this.Property(t => t.AbolishUserName)
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("ManuPlanTask");
            this.Property(t => t.ManuPlanTaskNumber).HasColumnName("ManuPlanTaskNumber");
            this.Property(t => t.PlanTaskTypeCode).HasColumnName("PlanTaskTypeCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.BomCode).HasColumnName("BomCode");
            this.Property(t => t.BorLineCode).HasColumnName("BorLineCode");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
            this.Property(t => t.ReleaseUser).HasColumnName("ReleaseUser");
            this.Property(t => t.ReleaseUserName).HasColumnName("ReleaseUserName");
            this.Property(t => t.ReleaseTime).HasColumnName("ReleaseTime");
            this.Property(t => t.AbolishUser).HasColumnName("AbolishUser");
            this.Property(t => t.AbolishUserName).HasColumnName("AbolishUserName");
            this.Property(t => t.AbolishTime).HasColumnName("AbolishTime");
            this.Property(t => t.PlanStartTime).HasColumnName("PlanStartTime");
            this.Property(t => t.PlanFinishTime).HasColumnName("PlanFinishTime");
            this.Property(t => t.RealStartTime).HasColumnName("RealStartTime");
            this.Property(t => t.RealFinishTime).HasColumnName("RealFinishTime");
            this.Property(t => t.PlanQuantity).HasColumnName("PlanQuantity");
            this.Property(t => t.FinishQuantity).HasColumnName("FinishQuantity");
            this.Property(t => t.AutoThrowQuality).HasColumnName("AutoThrowQuality");
            this.Property(t => t.NeedBomWarehouse).HasColumnName("NeedBomWarehouse");
            this.Property(t => t.AutoBomWarehouse).HasColumnName("AutoBomWarehouse");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.SyncStatus).HasColumnName("SyncStatus");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.BomMaster)
                .WithMany(t => t.ManuPlanTasks)
                .HasForeignKey(d => d.BomCode);
            this.HasRequired(t => t.PlanTaskType)
                .WithMany(t => t.ManuPlanTasks)
                .HasForeignKey(d => d.PlanTaskTypeCode);

        }
    }
}
