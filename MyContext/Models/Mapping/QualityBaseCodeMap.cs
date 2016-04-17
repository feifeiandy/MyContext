using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityBaseCodeMap : EntityTypeConfiguration<QualityBaseCode>
    {
        public QualityBaseCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CodeType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BaseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("QualityBaseCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CodeType).HasColumnName("CodeType");
            this.Property(t => t.BaseCode).HasColumnName("BaseCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
