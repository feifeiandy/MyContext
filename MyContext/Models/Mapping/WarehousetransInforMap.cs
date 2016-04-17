using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehousetransInforMap : EntityTypeConfiguration<WarehousetransInfor>
    {
        public WarehousetransInforMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Transdocuments)
                .HasMaxLength(50);

            this.Property(t => t.TransYear)
                .HasMaxLength(50);

            this.Property(t => t.TransMonth)
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .HasMaxLength(50);

            this.Property(t => t.WarehouseName)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.InvmasName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehousetransInfor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehousedetailId).HasColumnName("WarehousedetailId");
            this.Property(t => t.Transdocuments).HasColumnName("Transdocuments");
            this.Property(t => t.TransDate).HasColumnName("TransDate");
            this.Property(t => t.TransYear).HasColumnName("TransYear");
            this.Property(t => t.TransMonth).HasColumnName("TransMonth");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.WarehouseName).HasColumnName("WarehouseName");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.InvmasName).HasColumnName("InvmasName");
            this.Property(t => t.Transcount).HasColumnName("Transcount");
            this.Property(t => t.Transtype).HasColumnName("Transtype");
            this.Property(t => t.CurrentBalanceCount).HasColumnName("CurrentBalanceCount");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.TargetPrice).HasColumnName("TargetPrice");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.TransDateTime).HasColumnName("TransDateTime");
            this.Property(t => t.Virtuality).HasColumnName("Virtuality");
        }
    }
}
