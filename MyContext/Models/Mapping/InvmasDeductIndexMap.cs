using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class InvmasDeductIndexMap : EntityTypeConfiguration<InvmasDeductIndex>
    {
        public InvmasDeductIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.DeductCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GradeCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InvmasDeductIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.DeductCode).HasColumnName("DeductCode");
            this.Property(t => t.GradeCode).HasColumnName("GradeCode");
            this.Property(t => t.StandardValue).HasColumnName("StandardValue");
            this.Property(t => t.HasDefault).HasColumnName("HasDefault");
            this.Property(t => t.DefaultType).HasColumnName("DefaultType");
            this.Property(t => t.DefaultCount).HasColumnName("DefaultCount");
            this.Property(t => t.IsAuto).HasColumnName("IsAuto");
            this.Property(t => t.IsIncrease).HasColumnName("IsIncrease");
            this.Property(t => t.IncreaseRate).HasColumnName("IncreaseRate");
            this.Property(t => t.IncreaseStep).HasColumnName("IncreaseStep");
            this.Property(t => t.IncreaseLimit).HasColumnName("IncreaseLimit");
            this.Property(t => t.IncreaseType).HasColumnName("IncreaseType");
            this.Property(t => t.DeductRate).HasColumnName("DeductRate");
            this.Property(t => t.DeductStep).HasColumnName("DeductStep");
            this.Property(t => t.DeductLimit).HasColumnName("DeductLimit");
            this.Property(t => t.DeductType).HasColumnName("DeductType");
        }
    }
}
