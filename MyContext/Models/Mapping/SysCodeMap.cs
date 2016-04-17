using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysCodeMap : EntityTypeConfiguration<SysCode>
    {
        public SysCodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.CodeType, t.Code, t.Name, t.Stopped });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CodeType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SysCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CodeType).HasColumnName("CodeType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
