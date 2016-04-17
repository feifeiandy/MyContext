using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SampleTypeMap : EntityTypeConfiguration<SampleType>
    {
        public SampleTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SampleTypeCode);

            // Properties
            this.Property(t => t.SampleTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SampleType");
            this.Property(t => t.SampleTypeCode).HasColumnName("SampleTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.NeedSaved).HasColumnName("NeedSaved");
            this.Property(t => t.SavedCount).HasColumnName("SavedCount");
            this.Property(t => t.SampleCount).HasColumnName("SampleCount");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
