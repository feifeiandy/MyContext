using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseInvmaMap : EntityTypeConfiguration<WarehouseInvma>
    {
        public WarehouseInvmaMap()
        {
            // Primary Key
            this.HasKey(t => t.InvmasCode);

            // Properties
            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CharacterCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitCode)
                .HasMaxLength(50);

            this.Property(t => t.SecondUnitCode)
                .HasMaxLength(50);

            this.Property(t => t.ThirdUnitCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseInvmas");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.CharacterCode).HasColumnName("CharacterCode");
            this.Property(t => t.UnitCode).HasColumnName("UnitCode");
            this.Property(t => t.SecondUnitCode).HasColumnName("SecondUnitCode");
            this.Property(t => t.SecondConversionRate).HasColumnName("SecondConversionRate");
            this.Property(t => t.ThirdUnitCode).HasColumnName("ThirdUnitCode");
            this.Property(t => t.ThirdConversionRate).HasColumnName("ThirdConversionRate");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");

            // Relationships
            this.HasRequired(t => t.WarehouseInvcl)
                .WithMany(t => t.WarehouseInvmas)
                .HasForeignKey(d => d.InvclsCode);
            this.HasRequired(t => t.WarehouseInvmasCharacter)
                .WithMany(t => t.WarehouseInvmas)
                .HasForeignKey(d => d.CharacterCode);
            this.HasOptional(t => t.WarehouseUnit)
                .WithMany(t => t.WarehouseInvmas)
                .HasForeignKey(d => d.UnitCode);

        }
    }
}
