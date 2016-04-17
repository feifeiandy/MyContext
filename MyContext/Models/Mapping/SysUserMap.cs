using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
        public SysUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserCode);

            // Properties
            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LoginName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OfficialPhone)
                .HasMaxLength(50);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.DepartmentCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysUser");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LoginName).HasColumnName("LoginName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.NeedChangePassword).HasColumnName("NeedChangePassword");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.OfficialPhone).HasColumnName("OfficialPhone");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.IsLeader).HasColumnName("IsLeader");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsOnline).HasColumnName("IsOnline");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.DepartmentCode).HasColumnName("DepartmentCode");

            // Relationships
            this.HasMany(t => t.Warehouses)
                .WithMany(t => t.SysUsers)
                .Map(m =>
                    {
                        m.ToTable("WarehouseDuty");
                        m.MapLeftKey("UserCode");
                        m.MapRightKey("WarehouseCode");
                    });

            this.HasMany(t => t.Warehouses1)
                .WithMany(t => t.SysUsers1)
                .Map(m =>
                    {
                        m.ToTable("WarehouseKeeper");
                        m.MapLeftKey("UserCode");
                        m.MapRightKey("WarehouseCode");
                    });

            this.HasRequired(t => t.SysDepartment)
                .WithMany(t => t.SysUsers)
                .HasForeignKey(d => d.DepartmentCode);

        }
    }
}
