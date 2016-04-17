using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseMap : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseCode);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DisplayName)
                .HasMaxLength(50);

            this.Property(t => t.WarehouseTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCharacterCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Warehouse");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.WarehouseTypeCode).HasColumnName("WarehouseTypeCode");
            this.Property(t => t.InvmasCharacterCode).HasColumnName("InvmasCharacterCode");
            this.Property(t => t.UseLocation).HasColumnName("UseLocation");
            this.Property(t => t.Virtuality).HasColumnName("Virtuality");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.NeedBatchManager).HasColumnName("NeedBatchManager");

            // Relationships
            this.HasRequired(t => t.WarehouseInvmasCharacter)
                .WithMany(t => t.Warehouses)
                .HasForeignKey(d => d.InvmasCharacterCode);

        }
    }
}
