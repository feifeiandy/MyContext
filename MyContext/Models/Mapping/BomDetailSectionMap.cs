using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BomDetailSectionMap : EntityTypeConfiguration<BomDetailSection>
    {
        public BomDetailSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BorSectionCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BomDetailSection");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BomDetailId).HasColumnName("BomDetailId");
            this.Property(t => t.BorSectionCode).HasColumnName("BorSectionCode");
            this.Property(t => t.InputQuantity).HasColumnName("InputQuantity");
            this.Property(t => t.BadRate).HasColumnName("BadRate");

            // Relationships
            this.HasRequired(t => t.BomDetail)
                .WithMany(t => t.BomDetailSections)
                .HasForeignKey(d => d.BomDetailId);
            this.HasRequired(t => t.BorSection)
                .WithMany(t => t.BomDetailSections)
                .HasForeignKey(d => d.BorSectionCode);

        }
    }
}
