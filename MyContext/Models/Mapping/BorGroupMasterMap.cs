using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class BorGroupMasterMap : EntityTypeConfiguration<BorGroupMaster>
    {
        public BorGroupMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.BorGroupCode);

            // Properties
            this.Property(t => t.BorGroupCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BorLineCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BorGroupMaster");
            this.Property(t => t.BorGroupCode).HasColumnName("BorGroupCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
            this.Property(t => t.BorLineCode).HasColumnName("BorLineCode");

            // Relationships
            this.HasMany(t => t.WarehouseInvmas)
                .WithMany(t => t.BorGroupMasters)
                .Map(m =>
                    {
                        m.ToTable("BorGroupDetail");
                        m.MapLeftKey("BorGroupCode");
                        m.MapRightKey("InvmasCode");
                    });

            this.HasRequired(t => t.BorLine)
                .WithMany(t => t.BorGroupMasters)
                .HasForeignKey(d => d.BorLineCode);

        }
    }
}
