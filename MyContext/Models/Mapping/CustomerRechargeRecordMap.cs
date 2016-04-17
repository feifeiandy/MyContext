using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class CustomerRechargeRecordMap : EntityTypeConfiguration<CustomerRechargeRecord>
    {
        public CustomerRechargeRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerRechargeRecords");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessCustomerId).HasColumnName("BusinessCustomerId");
            this.Property(t => t.RechargeMoney).HasColumnName("RechargeMoney");
            this.Property(t => t.RechargeDate).HasColumnName("RechargeDate");
            this.Property(t => t.RfidID).HasColumnName("RfidID");
            this.Property(t => t.RechargeType).HasColumnName("RechargeType");

            // Relationships
            this.HasRequired(t => t.BusinessCustomer)
                .WithMany(t => t.CustomerRechargeRecords)
                .HasForeignKey(d => d.BusinessCustomerId);
            this.HasOptional(t => t.RFIDTag)
                .WithMany(t => t.CustomerRechargeRecords)
                .HasForeignKey(d => d.RfidID);

        }
    }
}
