using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SampleDetailMap : EntityTypeConfiguration<SampleDetail>
    {
        public SampleDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SampleNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SampleDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SampleNumber).HasColumnName("SampleNumber");

            // Relationships
            this.HasRequired(t => t.SampleMaster)
                .WithMany(t => t.SampleDetails)
                .HasForeignKey(d => d.SampleNumber);

        }
    }
}
