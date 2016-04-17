using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityGradeMap : EntityTypeConfiguration<QualityGrade>
    {
        public QualityGradeMap()
        {
            // Primary Key
            this.HasKey(t => t.GradeCode);

            // Properties
            this.Property(t => t.GradeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StandardCode)
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QualityGrade");
            this.Property(t => t.GradeCode).HasColumnName("GradeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.StandardCode).HasColumnName("StandardCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
        }
    }
}
