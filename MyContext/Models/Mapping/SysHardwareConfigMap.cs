using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysHardwareConfigMap : EntityTypeConfiguration<SysHardwareConfig>
    {
        public SysHardwareConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.MacAddress, t.StationCode, t.StationName });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MacAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StationCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StationName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SysHardwareConfig");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MacAddress).HasColumnName("MacAddress");
            this.Property(t => t.StationCode).HasColumnName("StationCode");
            this.Property(t => t.StationName).HasColumnName("StationName");
            this.Property(t => t.ConfigFile).HasColumnName("ConfigFile");
        }
    }
}
