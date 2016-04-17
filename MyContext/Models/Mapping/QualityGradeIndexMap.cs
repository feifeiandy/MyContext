using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityGradeIndexMap : EntityTypeConfiguration<QualityGradeIndex>
    {
        public QualityGradeIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.GradeCode, t.InvmasQualityIndexId, t.StandardValue, t.CompareType, t.Seq, t.Stopped });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GradeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasQualityIndexId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StandardValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompareType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QualityGradeIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GradeCode).HasColumnName("GradeCode");
            this.Property(t => t.InvmasQualityIndexId).HasColumnName("InvmasQualityIndexId");
            this.Property(t => t.StandardValue).HasColumnName("StandardValue");
            this.Property(t => t.StandardDownValue).HasColumnName("StandardDownValue");
            this.Property(t => t.CompareType).HasColumnName("CompareType");
            this.Property(t => t.Seq).HasColumnName("Seq");
            this.Property(t => t.NextCompareFlag).HasColumnName("NextCompareFlag");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
