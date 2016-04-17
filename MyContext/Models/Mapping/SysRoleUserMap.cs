using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysRoleUserMap : EntityTypeConfiguration<SysRoleUser>
    {
        public SysRoleUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoleCode, t.UserCode });

            // Properties
            this.Property(t => t.RoleCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysRoleUser");
            this.Property(t => t.RoleCode).HasColumnName("RoleCode");
            this.Property(t => t.UserCode).HasColumnName("UserCode");

            // Relationships
            this.HasRequired(t => t.SysRole)
                .WithMany(t => t.SysRoleUsers)
                .HasForeignKey(d => d.RoleCode);

        }
    }
}
