using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class WarehouseInvmasDetailMap : EntityTypeConfiguration<WarehouseInvmasDetail>
    {
        public WarehouseInvmasDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.InvmasCode);

            // Properties
            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseInvmasDetail");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.NeedBatch).HasColumnName("NeedBatch");
            this.Property(t => t.BatchPrinciple).HasColumnName("BatchPrinciple");
            this.Property(t => t.NeedSafetyStock).HasColumnName("NeedSafetyStock");
            this.Property(t => t.SafetyStock).HasColumnName("SafetyStock");
            this.Property(t => t.NeedUpperBoundStock).HasColumnName("NeedUpperBoundStock");
            this.Property(t => t.UpperBoundStock).HasColumnName("UpperBoundStock");
            this.Property(t => t.BatchKeepPeriod).HasColumnName("BatchKeepPeriod");

            // Relationships
            this.HasRequired(t => t.WarehouseInvma)
                .WithOptional(t => t.WarehouseInvmasDetail);

        }
    }
}
