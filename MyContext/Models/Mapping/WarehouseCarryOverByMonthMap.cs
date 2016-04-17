using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseCarryOverByMonthMap : EntityTypeConfiguration<WarehouseCarryOverByMonth>
    {
        public WarehouseCarryOverByMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseCarryOverByMonth");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CarryOverMonth).HasColumnName("CarryOverMonth");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.LastAmount).HasColumnName("LastAmount");
            this.Property(t => t.CurrentInAmount).HasColumnName("CurrentInAmount");
            this.Property(t => t.CurrentOutAmount).HasColumnName("CurrentOutAmount");
            this.Property(t => t.CurrentAmount).HasColumnName("CurrentAmount");

            // Relationships
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseCarryOverByMonths)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.WarehouseCarryOverByMonths)
                .HasForeignKey(d => d.AllocationCode);
            this.HasRequired(t => t.WarehouseInvcl)
                .WithMany(t => t.WarehouseCarryOverByMonths)
                .HasForeignKey(d => d.InvclsCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.WarehouseCarryOverByMonths)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
