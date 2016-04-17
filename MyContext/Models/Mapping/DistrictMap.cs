using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class DistrictMap : EntityTypeConfiguration<District>
    {
        public DistrictMap()
        {
            // Primary Key
            this.HasKey(t => t.DistrictCode);

            // Properties
            this.Property(t => t.DistrictCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("District");
            this.Property(t => t.DistrictCode).HasColumnName("DistrictCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
        }
    }
}
