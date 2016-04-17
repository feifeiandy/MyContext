using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseAmountMap : EntityTypeConfiguration<WarehouseAmount>
    {
        public WarehouseAmountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GrainCharacterCode)
                .HasMaxLength(50);

            this.Property(t => t.DistrictCode)
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("WarehouseAmount");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.CurrentAmount).HasColumnName("CurrentAmount");
            this.Property(t => t.GrainCharacterCode).HasColumnName("GrainCharacterCode");
            this.Property(t => t.InAmount).HasColumnName("InAmount");
            this.Property(t => t.InAmountNotConfirm).HasColumnName("InAmountNotConfirm");
            this.Property(t => t.OutAmount).HasColumnName("OutAmount");
            this.Property(t => t.OutAmountNotConfirm).HasColumnName("OutAmountNotConfirm");
            this.Property(t => t.ExpectationInAmount).HasColumnName("ExpectationInAmount");
            this.Property(t => t.ExpectationOutAmount).HasColumnName("ExpectationOutAmount");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.LastInDate).HasColumnName("LastInDate");
            this.Property(t => t.LastOutDate).HasColumnName("LastOutDate");
            this.Property(t => t.DistrictCode).HasColumnName("DistrictCode");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.District)
                .WithMany(t => t.WarehouseAmounts)
                .HasForeignKey(d => d.DistrictCode);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseAmounts)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.WarehouseAmounts)
                .HasForeignKey(d => d.AllocationCode);
            this.HasRequired(t => t.WarehouseInvcl)
                .WithMany(t => t.WarehouseAmounts)
                .HasForeignKey(d => d.InvclsCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.WarehouseAmounts)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
