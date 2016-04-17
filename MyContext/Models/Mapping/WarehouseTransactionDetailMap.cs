using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseTransactionDetailMap : EntityTypeConfiguration<WarehouseTransactionDetail>
    {
        public WarehouseTransactionDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseTransactionNumber)
                .IsRequired()
                .HasMaxLength(50);

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

            this.Property(t => t.ToWarehouseCode)
                .HasMaxLength(50);

            this.Property(t => t.ToAllocationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseTransactionDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseTransactionNumber).HasColumnName("WarehouseTransactionNumber");
            this.Property(t => t.Seq).HasColumnName("Seq");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.TransCount).HasColumnName("TransCount");
            this.Property(t => t.ToWarehouseCode).HasColumnName("ToWarehouseCode");
            this.Property(t => t.ToAllocationCode).HasColumnName("ToAllocationCode");
        }
    }
}
