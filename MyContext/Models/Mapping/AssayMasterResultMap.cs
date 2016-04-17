using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class AssayMasterResultMap : EntityTypeConfiguration<AssayMasterResult>
    {
        public AssayMasterResultMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AssayNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TestText)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssayMasterResult");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AssayNumber).HasColumnName("AssayNumber");
            this.Property(t => t.InvmasQualityIndexId).HasColumnName("InvmasQualityIndexId");
            this.Property(t => t.TestValue).HasColumnName("TestValue");
            this.Property(t => t.TestText).HasColumnName("TestText");
            this.Property(t => t.TestResult).HasColumnName("TestResult");

            // Relationships
            this.HasRequired(t => t.AssayMaster)
                .WithMany(t => t.AssayMasterResults)
                .HasForeignKey(d => d.AssayNumber);

        }
    }
}
