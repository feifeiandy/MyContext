using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class InvmasQualityIndexMap : EntityTypeConfiguration<InvmasQualityIndex>
    {
        public InvmasQualityIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.QualityCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TextStandardValue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InvmasQualityIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.QualityCode).HasColumnName("QualityCode");
            this.Property(t => t.StandardValue).HasColumnName("StandardValue");
            this.Property(t => t.StandardDownValue).HasColumnName("StandardDownValue");
            this.Property(t => t.CompareType).HasColumnName("CompareType");
            this.Property(t => t.TextStandardValue).HasColumnName("TextStandardValue");
            this.Property(t => t.IsNecessary).HasColumnName("IsNecessary");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
