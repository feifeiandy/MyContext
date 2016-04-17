using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BusinessCustomerMap : EntityTypeConfiguration<BusinessCustomer>
    {
        public BusinessCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CompanyCode)
                .HasMaxLength(100);

            this.Property(t => t.CompanyName)
                .HasMaxLength(200);

            this.Property(t => t.CompanyNameShort)
                .HasMaxLength(50);

            this.Property(t => t.CustomerTypeDes)
                .HasMaxLength(50);

            this.Property(t => t.Contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactID)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.Mobile)
                .HasMaxLength(20);

            this.Property(t => t.Fax)
                .HasMaxLength(20);

            this.Property(t => t.DepositBank)
                .HasMaxLength(100);

            this.Property(t => t.AccountNumber)
                .HasMaxLength(100);

            this.Property(t => t.TaxNumber)
                .HasMaxLength(100);

            this.Property(t => t.RegisteredAddress)
                .HasMaxLength(200);

            this.Property(t => t.ShippingAddress)
                .HasMaxLength(200);

            this.Property(t => t.PaymentMethodDes)
                .HasMaxLength(50);

            this.Property(t => t.PaymentPeriodsDes)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BusinessCustomer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyNameShort).HasColumnName("CompanyNameShort");
            this.Property(t => t.CustomerType).HasColumnName("CustomerType");
            this.Property(t => t.CustomerTypeDes).HasColumnName("CustomerTypeDes");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.DepositBank).HasColumnName("DepositBank");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.TaxNumber).HasColumnName("TaxNumber");
            this.Property(t => t.RegisteredAddress).HasColumnName("RegisteredAddress");
            this.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress");
            this.Property(t => t.PaymentMethod).HasColumnName("PaymentMethod");
            this.Property(t => t.PaymentMethodDes).HasColumnName("PaymentMethodDes");
            this.Property(t => t.PaymentPeriods).HasColumnName("PaymentPeriods");
            this.Property(t => t.PaymentPeriodsDes).HasColumnName("PaymentPeriodsDes");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsStopped).HasColumnName("IsStopped");
        }
    }
}
