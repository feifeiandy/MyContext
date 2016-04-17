using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class DeductIndexMap : EntityTypeConfiguration<DeductIndex>
    {
        public DeductIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.DeductCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QualityCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DeductIndex");
            this.Property(t => t.DeductCode).HasColumnName("DeductCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DeductType).HasColumnName("DeductType");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.QualityCode).HasColumnName("QualityCode");
        }
    }
}
