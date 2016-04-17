using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseInvclMap : EntityTypeConfiguration<WarehouseInvcl>
    {
        public WarehouseInvclMap()
        {
            // Primary Key
            this.HasKey(t => t.InvclsCode);

            // Properties
            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.ParentCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseInvcls");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.WarehouseInvcl1)
                .WithMany(t => t.WarehouseInvcls1)
                .HasForeignKey(d => d.ParentCode);

        }
    }
}
