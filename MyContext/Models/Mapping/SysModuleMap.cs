using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysModuleMap : EntityTypeConfiguration<SysModule>
    {
        public SysModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ModuleCode);

            // Properties
            this.Property(t => t.ModuleCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysModule");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
