using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseInvmasCharacterMap : EntityTypeConfiguration<WarehouseInvmasCharacter>
    {
        public WarehouseInvmasCharacterMap()
        {
            // Primary Key
            this.HasKey(t => t.InvmasCharacterCode);

            // Properties
            this.Property(t => t.InvmasCharacterCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("WarehouseInvmasCharacter");
            this.Property(t => t.InvmasCharacterCode).HasColumnName("InvmasCharacterCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
