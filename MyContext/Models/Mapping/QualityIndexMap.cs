using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityIndexMap : EntityTypeConfiguration<QualityIndex>
    {
        public QualityIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.QualityCode);

            // Properties
            this.Property(t => t.QualityCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(20);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QualityIndex");
            this.Property(t => t.QualityCode).HasColumnName("QualityCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsCompare).HasColumnName("IsCompare");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
