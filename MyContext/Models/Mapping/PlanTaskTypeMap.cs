using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class PlanTaskTypeMap : EntityTypeConfiguration<PlanTaskType>
    {
        public PlanTaskTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PlanTaskTypeCode);

            // Properties
            this.Property(t => t.PlanTaskTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PlanTaskType");
            this.Property(t => t.PlanTaskTypeCode).HasColumnName("PlanTaskTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PlanTaskMode).HasColumnName("PlanTaskMode");
            this.Property(t => t.AutoThrowQuality).HasColumnName("AutoThrowQuality");
            this.Property(t => t.NeedBomWarehouse).HasColumnName("NeedBomWarehouse");
            this.Property(t => t.AutoBomWarehouse).HasColumnName("AutoBomWarehouse");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
