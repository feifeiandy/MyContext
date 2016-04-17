using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseBaseConfigMap : EntityTypeConfiguration<WarehouseBaseConfig>
    {
        public WarehouseBaseConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ModuleCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("WarehouseBaseConfig");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.DumpHistory).HasColumnName("DumpHistory");
            this.Property(t => t.DeleteHistory).HasColumnName("DeleteHistory");
            this.Property(t => t.MonthCarryOverDate).HasColumnName("MonthCarryOverDate");
        }
    }
}
