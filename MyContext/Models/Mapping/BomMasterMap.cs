using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BomMasterMap : EntityTypeConfiguration<BomMaster>
    {
        public BomMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.BomCode);

            // Properties
            this.Property(t => t.BomCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BomMaster");
            this.Property(t => t.BomCode).HasColumnName("BomCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.Outputs).HasColumnName("Outputs");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.FinishDate).HasColumnName("FinishDate");
            this.Property(t => t.MixTime).HasColumnName("MixTime");

            // Relationships
            this.HasRequired(t => t.WarehouseInvma)
                .WithMany(t => t.BomMasters)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
