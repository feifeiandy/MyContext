using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorTypeMap : EntityTypeConfiguration<BorType>
    {
        public BorTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BorTypeCode);

            // Properties
            this.Property(t => t.BorTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BorType");
            this.Property(t => t.BorTypeCode).HasColumnName("BorTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
