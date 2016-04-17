using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class AssayResultMap : EntityTypeConfiguration<AssayResult>
    {
        public AssayResultMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TestText)
                .HasMaxLength(50);

            this.Property(t => t.AssayUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssayResult");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AssayDetailId).HasColumnName("AssayDetailId");
            this.Property(t => t.InvmasQualityIndexId).HasColumnName("InvmasQualityIndexId");
            this.Property(t => t.TestValue).HasColumnName("TestValue");
            this.Property(t => t.TestText).HasColumnName("TestText");
            this.Property(t => t.TestResult).HasColumnName("TestResult");
            this.Property(t => t.AssayUser).HasColumnName("AssayUser");
            this.Property(t => t.AssayTime).HasColumnName("AssayTime");
            this.Property(t => t.IsReference).HasColumnName("IsReference");

            // Relationships
            this.HasRequired(t => t.AssayDetail)
                .WithMany(t => t.AssayResults)
                .HasForeignKey(d => d.AssayDetailId);

        }
    }
}
