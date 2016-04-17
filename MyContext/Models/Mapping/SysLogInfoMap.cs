using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysLogInfoMap : EntityTypeConfiguration<SysLogInfo>
    {
        public SysLogInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UserCode, t.UserName, t.LogTime, t.LogType });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LogType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModuleCode)
                .HasMaxLength(50);

            this.Property(t => t.OperateIp)
                .HasMaxLength(20);

            this.Property(t => t.OperateMac)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysLogInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.LogTime).HasColumnName("LogTime");
            this.Property(t => t.LogType).HasColumnName("LogType");
            this.Property(t => t.Operate).HasColumnName("Operate");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.OperateIp).HasColumnName("OperateIp");
            this.Property(t => t.OperateMac).HasColumnName("OperateMac");
        }
    }
}
