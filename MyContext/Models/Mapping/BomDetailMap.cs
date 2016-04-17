using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BomDetailMap : EntityTypeConfiguration<BomDetail>
    {
        public BomDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BomCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BadRateExpression)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BomDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BomCode).HasColumnName("BomCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.StandardQuantity).HasColumnName("StandardQuantity");
            this.Property(t => t.StandardProportion).HasColumnName("StandardProportion");
            this.Property(t => t.BadRate).HasColumnName("BadRate");
            this.Property(t => t.BadRateExpression).HasColumnName("BadRateExpression");

            // Relationships
            this.HasRequired(t => t.BomMaster)
                .WithMany(t => t.BomDetails)
                .HasForeignKey(d => d.BomCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.BomDetails)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
