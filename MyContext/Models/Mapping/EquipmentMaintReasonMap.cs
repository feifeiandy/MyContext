using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class EquipmentMaintReasonMap : EntityTypeConfiguration<EquipmentMaintReason>
    {
        public EquipmentMaintReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintReasonCode);

            // Properties
            this.Property(t => t.MaintReasonCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaintReasonTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EquipmentMaintReason");
            this.Property(t => t.MaintReasonCode).HasColumnName("MaintReasonCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.MaintReasonTypeCode).HasColumnName("MaintReasonTypeCode");
            this.Property(t => t.Stopped).HasColumnName("Stopped");

            // Relationships
            this.HasMany(t => t.EquipmentTypes)
                .WithMany(t => t.EquipmentMaintReasons)
                .Map(m =>
                    {
                        m.ToTable("EquipmentTypeMaintReason");
                        m.MapLeftKey("MaintReasonCode");
                        m.MapRightKey("EquipmentTypeCode");
                    });

            this.HasRequired(t => t.EquipmentMaintReasonType)
                .WithMany(t => t.EquipmentMaintReasons)
                .HasForeignKey(d => d.MaintReasonTypeCode);

        }
    }
}
