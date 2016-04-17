using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseUnitMap : EntityTypeConfiguration<WarehouseUnit>
    {
        public WarehouseUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitCode);

            // Properties
            this.Property(t => t.UnitCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChineseName)
                .HasMaxLength(50);

            this.Property(t => t.EnglishName)
                .HasMaxLength(50);

            this.Property(t => t.UnitTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseUnit");
            this.Property(t => t.UnitCode).HasColumnName("UnitCode");
            this.Property(t => t.ChineseName).HasColumnName("ChineseName");
            this.Property(t => t.EnglishName).HasColumnName("EnglishName");
            this.Property(t => t.UnitTypeCode).HasColumnName("UnitTypeCode");
            this.Property(t => t.Rate).HasColumnName("Rate");

            // Relationships
            this.HasRequired(t => t.WarehouseUnitType)
                .WithMany(t => t.WarehouseUnits)
                .HasForeignKey(d => d.UnitTypeCode);

        }
    }
}
