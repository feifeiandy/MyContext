using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityStandardMap : EntityTypeConfiguration<QualityStandard>
    {
        public QualityStandardMap()
        {
            // Primary Key
            this.HasKey(t => t.StandardCode);

            // Properties
            this.Property(t => t.StandardCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GBCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QualityStandard");
            this.Property(t => t.StandardCode).HasColumnName("StandardCode");
            this.Property(t => t.GBCode).HasColumnName("GBCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
