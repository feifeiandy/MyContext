using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SampleMasterMap : EntityTypeConfiguration<SampleMaster>
    {
        public SampleMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.SampleNumber);

            // Properties
            this.Property(t => t.SampleNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SampleTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlanTaskBatchNumber)
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SampleMaster");
            this.Property(t => t.SampleNumber).HasColumnName("SampleNumber");
            this.Property(t => t.SampleTypeCode).HasColumnName("SampleTypeCode");
            this.Property(t => t.PlanTaskBatchNumber).HasColumnName("PlanTaskBatchNumber");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");

            // Relationships
            this.HasRequired(t => t.SampleType)
                .WithMany(t => t.SampleMasters)
                .HasForeignKey(d => d.SampleTypeCode);

        }
    }
}
