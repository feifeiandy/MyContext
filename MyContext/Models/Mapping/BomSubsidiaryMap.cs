using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BomSubsidiaryMap : EntityTypeConfiguration<BomSubsidiary>
    {
        public BomSubsidiaryMap()
        {
            // Primary Key
            this.HasKey(t => t.BomSubsidiaryCode);

            // Properties
            this.Property(t => t.BomSubsidiaryCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BomMasterCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BomSubsidiary");
            this.Property(t => t.BomSubsidiaryCode).HasColumnName("BomSubsidiaryCode");
            this.Property(t => t.BomMasterCode).HasColumnName("BomMasterCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.StandardQuantity).HasColumnName("StandardQuantity");

            // Relationships
            this.HasMany(t => t.BorSections)
                .WithMany(t => t.BomSubsidiaries)
                .Map(m =>
                    {
                        m.ToTable("BomSubsidiarySection");
                        m.MapLeftKey("BomSubsidiaryCode");
                        m.MapRightKey("BorSectionCode");
                    });

            this.HasRequired(t => t.BomMaster)
                .WithMany(t => t.BomSubsidiaries)
                .HasForeignKey(d => d.BomMasterCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.BomSubsidiaries)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
