using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysRightMap : EntityTypeConfiguration<SysRight>
    {
        public SysRightMap()
        {
            // Primary Key
            this.HasKey(t => t.RightCode);

            // Properties
            this.Property(t => t.RightCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysRight");
            this.Property(t => t.RightCode).HasColumnName("RightCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Stopped).HasColumnName("Stopped");

            // Relationships
            this.HasMany(t => t.SysRoles)
                .WithMany(t => t.SysRights)
                .Map(m =>
                    {
                        m.ToTable("SysRoleRight");
                        m.MapLeftKey("RightCode");
                        m.MapRightKey("RoleCode");
                    });


        }
    }
}
