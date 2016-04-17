using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseTypeMap : EntityTypeConfiguration<WarehouseType>
    {
        public WarehouseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseTypeCode);

            // Properties
            this.Property(t => t.WarehouseTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseType");
            this.Property(t => t.WarehouseTypeCode).HasColumnName("WarehouseTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.WarehouseType2)
                .WithMany(t => t.WarehouseType1)
                .HasForeignKey(d => d.ParentCode);

        }
    }
}
