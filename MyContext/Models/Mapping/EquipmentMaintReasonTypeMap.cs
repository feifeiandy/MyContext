using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class EquipmentMaintReasonTypeMap : EntityTypeConfiguration<EquipmentMaintReasonType>
    {
        public EquipmentMaintReasonTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintReasonTypeCode);

            // Properties
            this.Property(t => t.MaintReasonTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EquipmentMaintReasonType");
            this.Property(t => t.MaintReasonTypeCode).HasColumnName("MaintReasonTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
