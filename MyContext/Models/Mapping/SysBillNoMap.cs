using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysBillNoMap : EntityTypeConfiguration<SysBillNo>
    {
        public SysBillNoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.BillName, t.Prefix, t.NumBit, t.UseCompanyCode, t.UseDepartmentCode, t.System, t.IsTrans, t.RowVersion });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaxDate)
                .HasMaxLength(20);

            this.Property(t => t.Prefix)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NumBit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Style)
                .HasMaxLength(50);

            this.Property(t => t.System)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RowVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("SysBillNo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BillName).HasColumnName("BillName");
            this.Property(t => t.MaxNo).HasColumnName("MaxNo");
            this.Property(t => t.MaxDate).HasColumnName("MaxDate");
            this.Property(t => t.Prefix).HasColumnName("Prefix");
            this.Property(t => t.NumBit).HasColumnName("NumBit");
            this.Property(t => t.UseCompanyCode).HasColumnName("UseCompanyCode");
            this.Property(t => t.UseDepartmentCode).HasColumnName("UseDepartmentCode");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.EditDate).HasColumnName("EditDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.TransType).HasColumnName("TransType");
            this.Property(t => t.IsTrans).HasColumnName("IsTrans");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
        }
    }
}
