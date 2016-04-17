using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class CustomerRechargeInforMap : EntityTypeConfiguration<CustomerRechargeInfor>
    {
        public CustomerRechargeInforMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CustomerRechargeInfor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessCustomerId).HasColumnName("BusinessCustomerId");
            this.Property(t => t.RfidID).HasColumnName("RfidID");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.ExpenseMoney).HasColumnName("ExpenseMoney");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.IsStopped).HasColumnName("IsStopped");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RechargeType).HasColumnName("RechargeType");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");

            // Relationships
            this.HasRequired(t => t.BusinessCustomer)
                .WithMany(t => t.CustomerRechargeInfors)
                .HasForeignKey(d => d.BusinessCustomerId);
            this.HasOptional(t => t.RFIDTag)
                .WithMany(t => t.CustomerRechargeInfors)
                .HasForeignKey(d => d.RfidID);

        }
    }
}
