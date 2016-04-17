using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorLineSectionMap : EntityTypeConfiguration<BorLineSection>
    {
        public BorLineSectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BorLineCode, t.BorSectionCode });

            // Properties
            this.Property(t => t.BorLineCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BorSectionCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BorLineSection");
            this.Property(t => t.BorLineCode).HasColumnName("BorLineCode");
            this.Property(t => t.BorSectionCode).HasColumnName("BorSectionCode");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            // Relationships
            this.HasRequired(t => t.BorLine)
                .WithMany(t => t.BorLineSections)
                .HasForeignKey(d => d.BorLineCode);
            this.HasRequired(t => t.BorSection)
                .WithMany(t => t.BorLineSections)
                .HasForeignKey(d => d.BorSectionCode);

        }
    }
}
