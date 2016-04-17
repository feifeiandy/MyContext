using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseUnitConversionMap : EntityTypeConfiguration<WarehouseUnitConversion>
    {
        public WarehouseUnitConversionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FromUnitCode, t.ToUnitCode });

            // Properties
            this.Property(t => t.FromUnitCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ToUnitCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseUnitConversion");
            this.Property(t => t.FromUnitCode).HasColumnName("FromUnitCode");
            this.Property(t => t.ToUnitCode).HasColumnName("ToUnitCode");
            this.Property(t => t.ConversionRate).HasColumnName("ConversionRate");

            // Relationships
            this.HasRequired(t => t.WarehouseUnit)
                .WithMany(t => t.WarehouseUnitConversions)
                .HasForeignKey(d => d.FromUnitCode);
            this.HasRequired(t => t.WarehouseUnit1)
                .WithMany(t => t.WarehouseUnitConversions1)
                .HasForeignKey(d => d.ToUnitCode);

        }
    }
}
