using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysCompanyInfoMap : EntityTypeConfiguration<SysCompanyInfo>
    {
        public SysCompanyInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CompanyCode, t.Symbol });

            // Properties
            this.Property(t => t.CompanyCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Relation)
                .HasMaxLength(50);

            this.Property(t => t.Symbol)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(200);

            this.Property(t => t.Telephone)
                .HasMaxLength(20);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.HomePage)
                .HasMaxLength(50);

            this.Property(t => t.DepositBank)
                .HasMaxLength(50);

            this.Property(t => t.BankAccount)
                .HasMaxLength(50);

            this.Property(t => t.TaxNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysCompanyInfo");
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Relation).HasColumnName("Relation");
            this.Property(t => t.Symbol).HasColumnName("Symbol");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.HomePage).HasColumnName("HomePage");
            this.Property(t => t.DepositBank).HasColumnName("DepositBank");
            this.Property(t => t.BankAccount).HasColumnName("BankAccount");
            this.Property(t => t.TaxNo).HasColumnName("TaxNo");
            this.Property(t => t.Capital).HasColumnName("Capital");
            this.Property(t => t.Capacity).HasColumnName("Capacity");
            this.Property(t => t.DepotNum).HasColumnName("DepotNum");
            this.Property(t => t.FloorSurface).HasColumnName("FloorSurface");
            this.Property(t => t.EmployeeNum).HasColumnName("EmployeeNum");
            this.Property(t => t.DockNum).HasColumnName("DockNum");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
