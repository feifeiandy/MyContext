using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseLocationMap : EntityTypeConfiguration<WarehouseLocation>
    {
        public WarehouseLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseCode);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseLocation");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.PointX).HasColumnName("PointX");
            this.Property(t => t.PointY).HasColumnName("PointY");
            this.Property(t => t.DrawWidth).HasColumnName("DrawWidth");
            this.Property(t => t.DrawHeight).HasColumnName("DrawHeight");
            this.Property(t => t.ImageWidth).HasColumnName("ImageWidth");
            this.Property(t => t.ImageHeight).HasColumnName("ImageHeight");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithOptional(t => t.WarehouseLocation);

        }
    }
}
