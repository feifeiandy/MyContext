using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseBatchDetailMap : EntityTypeConfiguration<WarehouseBatchDetail>
    {
        public WarehouseBatchDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TransCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TransBillType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseBatchDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseBatchId).HasColumnName("WarehouseBatchId");
            this.Property(t => t.TransCode).HasColumnName("TransCode");
            this.Property(t => t.TransBillType).HasColumnName("TransBillType");
            this.Property(t => t.TransType).HasColumnName("TransType");
            this.Property(t => t.TransCount).HasColumnName("TransCount");

            // Relationships
            this.HasRequired(t => t.WarehouseBatchMaster)
                .WithMany(t => t.WarehouseBatchDetails)
                .HasForeignKey(d => d.WarehouseBatchId);

        }
    }
}
