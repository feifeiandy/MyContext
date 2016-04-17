using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class SysFunctionMap : EntityTypeConfiguration<SysFunction>
    {
        public SysFunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.FunctionCode);

            // Properties
            this.Property(t => t.FunctionCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Assembly)
                .HasMaxLength(500);

            this.Property(t => t.ClassName)
                .HasMaxLength(500);

            this.Property(t => t.OperationCode)
                .HasMaxLength(50);

            this.Property(t => t.OperationName)
                .HasMaxLength(50);

            this.Property(t => t.Params)
                .HasMaxLength(500);

            this.Property(t => t.ModuleCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SysFunction");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Assembly).HasColumnName("Assembly");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.OperationCode).HasColumnName("OperationCode");
            this.Property(t => t.OperationName).HasColumnName("OperationName");
            this.Property(t => t.Params).HasColumnName("Params");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.ModuleCode).HasColumnName("ModuleCode");

            // Relationships
            this.HasOptional(t => t.SysModule)
                .WithMany(t => t.SysFunctions)
                .HasForeignKey(d => d.ModuleCode);

        }
    }
}
