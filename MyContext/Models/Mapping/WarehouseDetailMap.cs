using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseDetailMap : EntityTypeConfiguration<WarehouseDetail>
    {
        public WarehouseDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseCode);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Structure)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseDetail");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.Capacity).HasColumnName("Capacity");
            this.Property(t => t.Structure).HasColumnName("Structure");
            this.Property(t => t.BuildupYear).HasColumnName("BuildupYear");
            this.Property(t => t.HeatInsulation).HasColumnName("HeatInsulation");
            this.Property(t => t.WindowNum).HasColumnName("WindowNum");
            this.Property(t => t.DoorNum).HasColumnName("DoorNum");
            this.Property(t => t.StorageHeight).HasColumnName("StorageHeight");
            this.Property(t => t.WallInnerLength).HasColumnName("WallInnerLength");
            this.Property(t => t.WallInnerWidth).HasColumnName("WallInnerWidth");
            this.Property(t => t.WallOuterLength).HasColumnName("WallOuterLength");
            this.Property(t => t.WallOuterWidth).HasColumnName("WallOuterWidth");
            this.Property(t => t.EaveHeight).HasColumnName("EaveHeight");
            this.Property(t => t.RoofHeight).HasColumnName("RoofHeight");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithOptional(t => t.WarehouseDetail);

        }
    }
}
