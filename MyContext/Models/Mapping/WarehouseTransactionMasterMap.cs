using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseTransactionMasterMap : EntityTypeConfiguration<WarehouseTransactionMaster>
    {
        public WarehouseTransactionMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.WarehouseTransactionNumber);

            // Properties
            this.Property(t => t.WarehouseTransactionNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.CreateUserName)
                .HasMaxLength(50);

            this.Property(t => t.ConfirmUser)
                .HasMaxLength(50);

            this.Property(t => t.ConfirmUserName)
                .HasMaxLength(50);

            this.Property(t => t.AbolishUser)
                .HasMaxLength(50);

            this.Property(t => t.AbolishUserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseTransactionMaster");
            this.Property(t => t.WarehouseTransactionNumber).HasColumnName("WarehouseTransactionNumber");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
            this.Property(t => t.ConfirmUser).HasColumnName("ConfirmUser");
            this.Property(t => t.ConfirmUserName).HasColumnName("ConfirmUserName");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.AbolishUser).HasColumnName("AbolishUser");
            this.Property(t => t.AbolishUserName).HasColumnName("AbolishUserName");
            this.Property(t => t.AbolishTime).HasColumnName("AbolishTime");
            this.Property(t => t.PrintCount).HasColumnName("PrintCount");
        }
    }
}
