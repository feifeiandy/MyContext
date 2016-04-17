using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class AssayMasterMap : EntityTypeConfiguration<AssayMaster>
    {
        public AssayMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.AssayNumber);

            // Properties
            this.Property(t => t.AssayNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConfirmUser)
                .HasMaxLength(50);

            this.Property(t => t.PlanTaskBatchNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssayMaster");
            this.Property(t => t.AssayNumber).HasColumnName("AssayNumber");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ConfirmUser).HasColumnName("ConfirmUser");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.AssayResult).HasColumnName("AssayResult");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PlanTaskBatchNumber).HasColumnName("PlanTaskBatchNumber");
        }
    }
}
