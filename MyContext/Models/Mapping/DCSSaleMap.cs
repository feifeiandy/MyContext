using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class DCSSaleMap : EntityTypeConfiguration<DCSSale>
    {
        public DCSSaleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseTransactionNumber)
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.ShipNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DCSSales");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseTransactionNumber).HasColumnName("WarehouseTransactionNumber");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.ShipNo).HasColumnName("ShipNo");
            this.Property(t => t.OutCount).HasColumnName("OutCount");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.SyncStatus).HasColumnName("SyncStatus");
        }
    }
}
