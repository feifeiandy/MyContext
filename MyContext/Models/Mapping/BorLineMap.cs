using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorLineMap : EntityTypeConfiguration<BorLine>
    {
        public BorLineMap()
        {
            // Primary Key
            this.HasKey(t => t.BorLineCode);

            // Properties
            this.Property(t => t.BorLineCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BorTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BorLine");
            this.Property(t => t.BorLineCode).HasColumnName("BorLineCode");
            this.Property(t => t.BorTypeCode).HasColumnName("BorTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Stopped).HasColumnName("Stopped");

            // Relationships
            this.HasRequired(t => t.BorType)
                .WithMany(t => t.BorLines)
                .HasForeignKey(d => d.BorTypeCode);

        }
    }
}
