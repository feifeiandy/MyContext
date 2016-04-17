using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class RFIDTagMap : EntityTypeConfiguration<RFIDTag>
    {
        public RFIDTagMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TagNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TagId)
                .HasMaxLength(200);

            this.Property(t => t.TagIdHex)
                .HasMaxLength(200);

            this.Property(t => t.RegisterUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RFIDTag");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TagNumber).HasColumnName("TagNumber");
            this.Property(t => t.TagId).HasColumnName("TagId");
            this.Property(t => t.TagIdHex).HasColumnName("TagIdHex");
            this.Property(t => t.TagType).HasColumnName("TagType");
            this.Property(t => t.TagFlag).HasColumnName("TagFlag");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
            this.Property(t => t.RegisterUser).HasColumnName("RegisterUser");
            this.Property(t => t.Stopped).HasColumnName("Stopped");
        }
    }
}
