using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        public EquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipmentCode);

            // Properties
            this.Property(t => t.EquipmentCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EquipmentTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EquipmentModel)
                .HasMaxLength(50);

            this.Property(t => t.EquipmentSpec)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Equipment");
            this.Property(t => t.EquipmentCode).HasColumnName("EquipmentCode");
            this.Property(t => t.EquipmentTypeCode).HasColumnName("EquipmentTypeCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EquipmentModel).HasColumnName("EquipmentModel");
            this.Property(t => t.EquipmentSpec).HasColumnName("EquipmentSpec");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.WorkTimeRate).HasColumnName("WorkTimeRate");
            this.Property(t => t.WorkTimeMaintain).HasColumnName("WorkTimeMaintain");
            this.Property(t => t.WorkTimeSingle).HasColumnName("WorkTimeSingle");
            this.Property(t => t.WorkTimeTotal).HasColumnName("WorkTimeTotal");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.EquipmentType)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.EquipmentTypeCode);

        }
    }
}
