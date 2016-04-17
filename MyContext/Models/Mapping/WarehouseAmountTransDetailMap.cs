using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseAmountTransDetailMap : EntityTypeConfiguration<WarehouseAmountTransDetail>
    {
        public WarehouseAmountTransDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TransNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TransDocuments)
                .IsRequired()
                .HasMaxLength(50);

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

            // Table & Column Mappings
            this.ToTable("WarehouseAmountTransDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BatchMasterId).HasColumnName("BatchMasterId");
            this.Property(t => t.TransNumber).HasColumnName("TransNumber");
            this.Property(t => t.TransDetailId).HasColumnName("TransDetailId");
            this.Property(t => t.TransDocuments).HasColumnName("TransDocuments");
            this.Property(t => t.TransDate).HasColumnName("TransDate");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.TransCount).HasColumnName("TransCount");
            this.Property(t => t.GrainCharacterCode).HasColumnName("GrainCharacterCode");
            this.Property(t => t.TransInCount).HasColumnName("TransInCount");
            this.Property(t => t.TransOutCount).HasColumnName("TransOutCount");
            this.Property(t => t.TransType).HasColumnName("TransType");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.TransMoney).HasColumnName("TransMoney");

            // Relationships
            this.HasOptional(t => t.GrainCharacter)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.GrainCharacterCode);
            this.HasRequired(t => t.Warehouse)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.WarehouseCode);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.AllocationCode);
            this.HasOptional(t => t.WarehouseBatchMaster)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.BatchMasterId);
            this.HasRequired(t => t.WarehouseInvcl)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.InvclsCode);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.WarehouseAmountTransDetails)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
