using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysUserFavoriteMap : EntityTypeConfiguration<SysUserFavorite>
    {
        public SysUserFavoriteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserCode, t.MenuCode });

            // Properties
            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysUserFavorites");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.MenuCode).HasColumnName("MenuCode");

            // Relationships
            this.HasRequired(t => t.SysMenu)
                .WithMany(t => t.SysUserFavorites)
                .HasForeignKey(d => d.MenuCode);

        }
    }
}
