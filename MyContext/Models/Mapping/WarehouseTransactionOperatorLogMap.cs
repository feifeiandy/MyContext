using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseTransactionOperatorLogMap : EntityTypeConfiguration<WarehouseTransactionOperatorLog>
    {
        public WarehouseTransactionOperatorLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Operator)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseTransactionOperatorLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.Operate).HasColumnName("Operate");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
