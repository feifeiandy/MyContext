using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorSectionMap : EntityTypeConfiguration<BorSection>
    {
        public BorSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.BorSectionCode);

            // Properties
            this.Property(t => t.BorSectionCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BorSection");
            this.Property(t => t.BorSectionCode).HasColumnName("BorSectionCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
