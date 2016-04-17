using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyContext.Models.Mapping
{
    public class CusAndCardInforMap : EntityTypeConfiguration<CusAndCardInfor>
    {
        public CusAndCardInforMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.RechargeYear)
                .HasMaxLength(50);

            this.Property(t => t.RechargeMonth)
                .HasMaxLength(50);

            this.Property(t => t.TargetInvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.BaseInvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.RfTagId)
                .HasMaxLength(50);

            this.Property(t => t.BaseInvmasName)
                .HasMaxLength(50);

            this.Property(t => t.TargetInvmasName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CusAndCardInfor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CusRechargeInforId).HasColumnName("CusRechargeInforId");
            this.Property(t => t.CusRecordsId).HasColumnName("CusRecordsId");
            this.Property(t => t.CusTransInforId).HasColumnName("CusTransInforId");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.RechargeDate).HasColumnName("RechargeDate");
            this.Property(t => t.RechargeYear).HasColumnName("RechargeYear");
            this.Property(t => t.RechargeMonth).HasColumnName("RechargeMonth");
            this.Property(t => t.TargetInvmasCode).HasColumnName("TargetInvmasCode");
            this.Property(t => t.BaseInvmasCode).HasColumnName("BaseInvmasCode");
            this.Property(t => t.TargetPrice).HasColumnName("TargetPrice");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.TargetWeight).HasColumnName("TargetWeight");
            this.Property(t => t.BaseWeight).HasColumnName("BaseWeight");
            this.Property(t => t.BehaviorType).HasColumnName("BehaviorType");
            this.Property(t => t.RechargeType).HasColumnName("RechargeType");
            this.Property(t => t.TargetBalance).HasColumnName("TargetBalance");
            this.Property(t => t.BaseBalance).HasColumnName("BaseBalance");
            this.Property(t => t.RfTagId).HasColumnName("RfTagId");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.RechargeDatetime).HasColumnName("RechargeDatetime");
            this.Property(t => t.RechargeOrSaleWeight).HasColumnName("RechargeOrSaleWeight");
            this.Property(t => t.BaseInvmasName).HasColumnName("BaseInvmasName");
            this.Property(t => t.TargetInvmasName).HasColumnName("TargetInvmasName");
        }
    }
}
