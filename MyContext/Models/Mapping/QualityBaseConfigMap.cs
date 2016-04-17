using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class QualityBaseConfigMap : EntityTypeConfiguration<QualityBaseConfig>
    {
        public QualityBaseConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ModuleCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QualityBaseConfig");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");
            this.Property(t => t.NeedJudgeGrade).HasColumnName("NeedJudgeGrade");
            this.Property(t => t.GradeUseInvmas).HasColumnName("GradeUseInvmas");
            this.Property(t => t.NeedGradePrice).HasColumnName("NeedGradePrice");
            this.Property(t => t.NeedSample).HasColumnName("NeedSample");
        }
    }
}
