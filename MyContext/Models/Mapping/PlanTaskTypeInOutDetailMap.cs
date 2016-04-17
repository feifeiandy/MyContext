using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class PlanTaskTypeInOutDetailMap : EntityTypeConfiguration<PlanTaskTypeInOutDetail>
    {
        public PlanTaskTypeInOutDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PlanTaskTypeCode);

            // Properties
            this.Property(t => t.PlanTaskTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PlanTaskTypeInOutDetail");
            this.Property(t => t.PlanTaskTypeCode).HasColumnName("PlanTaskTypeCode");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
            this.Property(t => t.NeedVehicle).HasColumnName("NeedVehicle");
            this.Property(t => t.NeedBorLine).HasColumnName("NeedBorLine");
            this.Property(t => t.BorWeight).HasColumnName("BorWeight");
            this.Property(t => t.NeedWorkplace).HasColumnName("NeedWorkplace");
            this.Property(t => t.NeedDuty).HasColumnName("NeedDuty");
            this.Property(t => t.WeightMode).HasColumnName("WeightMode");
            this.Property(t => t.NeedSettle).HasColumnName("NeedSettle");
            this.Property(t => t.NeedCheckOut).HasColumnName("NeedCheckOut");

            // Relationships
            this.HasRequired(t => t.PlanTaskType)
                .WithOptional(t => t.PlanTaskTypeInOutDetail);

        }
    }
}
