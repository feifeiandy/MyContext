using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysDepartmentMap : EntityTypeConfiguration<SysDepartment>
    {
        public SysDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentCode);

            // Properties
            this.Property(t => t.DepartmentCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysDepartment");
            this.Property(t => t.DepartmentCode).HasColumnName("DepartmentCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ShowIndex).HasColumnName("ShowIndex");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsRealy).HasColumnName("IsRealy");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");

            // Relationships
            this.HasOptional(t => t.SysDepartment2)
                .WithMany(t => t.SysDepartment1)
                .HasForeignKey(d => d.ParentCode);

        }
    }
}
