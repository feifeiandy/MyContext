using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class AssayDetailMap : EntityTypeConfiguration<AssayDetail>
    {
        public AssayDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AssayNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssayDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AssayNumber).HasColumnName("AssayNumber");
            this.Property(t => t.SampleDetailId).HasColumnName("SampleDetailId");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");

            // Relationships
            this.HasRequired(t => t.AssayMaster)
                .WithMany(t => t.AssayDetails)
                .HasForeignKey(d => d.AssayNumber);
            this.HasOptional(t => t.SampleDetail)
                .WithMany(t => t.AssayDetails)
                .HasForeignKey(d => d.SampleDetailId);

        }
    }
}
