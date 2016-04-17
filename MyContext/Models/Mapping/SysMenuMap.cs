using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysMenuMap : EntityTypeConfiguration<SysMenu>
    {
        public SysMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuCode);

            // Properties
            this.Property(t => t.MenuCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DisplayName)
                .HasMaxLength(50);

            this.Property(t => t.ModuleCode)
                .HasMaxLength(50);

            this.Property(t => t.FunctionCode)
                .HasMaxLength(50);

            this.Property(t => t.ControlType)
                .HasMaxLength(50);

            this.Property(t => t.ImagePosition)
                .HasMaxLength(50);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysMenu");
            this.Property(t => t.MenuCode).HasColumnName("MenuCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.ShowIndex).HasColumnName("ShowIndex");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Layer).HasColumnName("Layer");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.BigImage).HasColumnName("BigImage");
            this.Property(t => t.SmallImage).HasColumnName("SmallImage");
            this.Property(t => t.ShowImage).HasColumnName("ShowImage");
            this.Property(t => t.ShowText).HasColumnName("ShowText");
            this.Property(t => t.ControlType).HasColumnName("ControlType");
            this.Property(t => t.ImagePosition).HasColumnName("ImagePosition");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");

            // Relationships
            this.HasMany(t => t.SysRights)
                .WithMany(t => t.SysMenus)
                .Map(m =>
                    {
                        m.ToTable("SysRightMenu");
                        m.MapLeftKey("MenuCode");
                        m.MapRightKey("RightCode");
                    });

            this.HasMany(t => t.SysSubSystems)
                .WithMany(t => t.SysMenus)
                .Map(m =>
                    {
                        m.ToTable("SysSubSystemMenu");
                        m.MapLeftKey("MenuCode");
                        m.MapRightKey("SubSystemCode");
                    });

            this.HasOptional(t => t.SysFunction)
                .WithMany(t => t.SysMenus)
                .HasForeignKey(d => d.FunctionCode);
            this.HasOptional(t => t.SysModule)
                .WithMany(t => t.SysMenus)
                .HasForeignKey(d => d.ModuleCode);

        }
    }
}
