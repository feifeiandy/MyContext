using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class ManuPlanTaskBomMap : EntityTypeConfiguration<ManuPlanTaskBom>
    {
        public ManuPlanTaskBomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ManPlanTaskNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ManuPlanTaskBom");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ManPlanTaskNumber).HasColumnName("ManPlanTaskNumber");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.RequireQuantity).HasColumnName("RequireQuantity");
            this.Property(t => t.RealQuantity).HasColumnName("RealQuantity");

            // Relationships
            this.HasRequired(t => t.ManuPlanTask)
                .WithMany(t => t.ManuPlanTaskBoms)
                .HasForeignKey(d => d.ManPlanTaskNumber);
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.ManuPlanTaskBoms)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
