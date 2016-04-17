using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class EquipmentTypeMap : EntityTypeConfiguration<EquipmentType>
    {
        public EquipmentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipmentTypeCode);

            // Properties
            this.Property(t => t.EquipmentTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EquipmentType");
            this.Property(t => t.EquipmentTypeCode).HasColumnName("EquipmentTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsWeight).HasColumnName("IsWeight");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
