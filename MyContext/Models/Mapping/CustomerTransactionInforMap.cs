using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class CustomerTransactionInforMap : EntityTypeConfiguration<CustomerTransactionInfor>
    {
        public CustomerTransactionInforMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.WarehouseCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CustomerTransactionInfor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessCustomerId).HasColumnName("BusinessCustomerId");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.TransTime).HasColumnName("TransTime");
            this.Property(t => t.TransType).HasColumnName("TransType");

            // Relationships
            this.HasRequired(t => t.BusinessCustomer)
                .WithMany(t => t.CustomerTransactionInfors)
                .HasForeignKey(d => d.BusinessCustomerId);

        }
    }
}
