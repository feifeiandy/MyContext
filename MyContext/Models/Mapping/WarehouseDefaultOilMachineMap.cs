using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseDefaultOilMachineMap : EntityTypeConfiguration<WarehouseDefaultOilMachine>
    {
        public WarehouseDefaultOilMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OilMachineIp)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseDefaultOilMachine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OilMachineIp).HasColumnName("OilMachineIp");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
