using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysSubSystemMap : EntityTypeConfiguration<SysSubSystem>
    {
        public SysSubSystemMap()
        {
            // Primary Key
            this.HasKey(t => t.SubSystemCode);

            // Properties
            this.Property(t => t.SubSystemCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SubSystemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MetroBackColor)
                .HasMaxLength(50);

            this.Property(t => t.MetroForeColor)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysSubSystem");
            this.Property(t => t.SubSystemCode).HasColumnName("SubSystemCode");
            this.Property(t => t.SubSystemName).HasColumnName("SubSystemName");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.MetroType).HasColumnName("MetroType");
            this.Property(t => t.MetroBackColor).HasColumnName("MetroBackColor");
            this.Property(t => t.MetroForeColor).HasColumnName("MetroForeColor");
            this.Property(t => t.IconString).HasColumnName("IconString");
        }
    }
}
