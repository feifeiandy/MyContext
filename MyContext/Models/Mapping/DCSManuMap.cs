using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class DCSManuMap : EntityTypeConfiguration<DCSManu>
    {
        public DCSManuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseTransactionNumber)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.OutWarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OutAllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.InWarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InAllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.ManuPlanNum)
                .HasMaxLength(50);

            this.Property(t => t.BomNum)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DCSManu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseTransactionNumber).HasColumnName("WarehouseTransactionNumber");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.OutWarehouseCode).HasColumnName("OutWarehouseCode");
            this.Property(t => t.OutAllocationCode).HasColumnName("OutAllocationCode");
            this.Property(t => t.InWarehouseCode).HasColumnName("InWarehouseCode");
            this.Property(t => t.InAllocationCode).HasColumnName("InAllocationCode");
            this.Property(t => t.ManuCount).HasColumnName("ManuCount");
            this.Property(t => t.ManuTime).HasColumnName("ManuTime");
            this.Property(t => t.ManuPlanNum).HasColumnName("ManuPlanNum");
            this.Property(t => t.SyncStatus).HasColumnName("SyncStatus");
            this.Property(t => t.BomNum).HasColumnName("BomNum");
        }
    }
}
