using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorSectionEquipmentMap : EntityTypeConfiguration<BorSectionEquipment>
    {
        public BorSectionEquipmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BorSectionCode, t.EquipmentCode });

            // Properties
            this.Property(t => t.BorSectionCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EquipmentCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BorSectionEquipment");
            this.Property(t => t.BorSectionCode).HasColumnName("BorSectionCode");
            this.Property(t => t.EquipmentCode).HasColumnName("EquipmentCode");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.EquipmentOperateKind).HasColumnName("EquipmentOperateKind");
            this.Property(t => t.EquipmentOperateRemark).HasColumnName("EquipmentOperateRemark");

            // Relationships
            this.HasRequired(t => t.BorSection)
                .WithMany(t => t.BorSectionEquipments)
                .HasForeignKey(d => d.BorSectionCode);
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.BorSectionEquipments)
                .HasForeignKey(d => d.EquipmentCode);

        }
    }
}
