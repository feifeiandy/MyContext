using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class LipaDensityInfoMap : EntityTypeConfiguration<LipaDensityInfo>
    {
        public LipaDensityInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.InvmasCode);

            // Properties
            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LipaDensityInfo");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.StandardTemperature).HasColumnName("StandardTemperature");
            this.Property(t => t.StandardDensity).HasColumnName("StandardDensity");
            this.Property(t => t.ChangeDensity).HasColumnName("ChangeDensity");

            // Relationships
            this.HasRequired(t => t.WarehouseInvma)
                .WithOptional(t => t.LipaDensityInfo);

        }
    }
}
