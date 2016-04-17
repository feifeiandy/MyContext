using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseUnitTypeMap : EntityTypeConfiguration<WarehouseUnitType>
    {
        public WarehouseUnitTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitTypeCode);

            // Properties
            this.Property(t => t.UnitTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseUnitType");
            this.Property(t => t.UnitTypeCode).HasColumnName("UnitTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
