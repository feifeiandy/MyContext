using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class GrainCharacterMap : EntityTypeConfiguration<GrainCharacter>
    {
        public GrainCharacterMap()
        {
            // Primary Key
            this.HasKey(t => t.GrainCharacterCode);

            // Properties
            this.Property(t => t.GrainCharacterCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GrainCharacter");
            this.Property(t => t.GrainCharacterCode).HasColumnName("GrainCharacterCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.GrainCharacter2)
                .WithMany(t => t.GrainCharacter1)
                .HasForeignKey(d => d.ParentCode);

        }
    }
}
