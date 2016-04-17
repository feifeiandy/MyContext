using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseInvma
    {
        public WarehouseInvma()
        {
            this.BomDetails = new List<BomDetail>();
            this.BomMasters = new List<BomMaster>();
            this.BomSubsidiaries = new List<BomSubsidiary>();
            this.ManuPlanTaskBatchInWarehouses = new List<ManuPlanTaskBatchInWarehouse>();
            this.ManuPlanTaskBatchOutWarehouses = new List<ManuPlanTaskBatchOutWarehouse>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
            this.ManuPlanTaskBoms = new List<ManuPlanTaskBom>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseCarryOverByDays = new List<WarehouseCarryOverByDay>();
            this.WarehouseCarryOverByMonths = new List<WarehouseCarryOverByMonth>();
            this.BorGroupMasters = new List<BorGroupMaster>();
        }

        public string InvmasCode { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public string InvclsCode { get; set; }
        public string CharacterCode { get; set; }
        public string UnitCode { get; set; }
        public string SecondUnitCode { get; set; }
        public Nullable<decimal> SecondConversionRate { get; set; }
        public string ThirdUnitCode { get; set; }
        public Nullable<decimal> ThirdConversionRate { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public virtual ICollection<BomDetail> BomDetails { get; set; }
        public virtual ICollection<BomMaster> BomMasters { get; set; }
        public virtual ICollection<BomSubsidiary> BomSubsidiaries { get; set; }
        public virtual LipaDensityInfo LipaDensityInfo { get; set; }
        public virtual ICollection<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
        public virtual ICollection<ManuPlanTaskBom> ManuPlanTaskBoms { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseCarryOverByDay> WarehouseCarryOverByDays { get; set; }
        public virtual ICollection<WarehouseCarryOverByMonth> WarehouseCarryOverByMonths { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl { get; set; }
        public virtual WarehouseInvmasCharacter WarehouseInvmasCharacter { get; set; }
        public virtual WarehouseUnit WarehouseUnit { get; set; }
        public virtual WarehouseInvmasDetail WarehouseInvmasDetail { get; set; }
        public virtual ICollection<BorGroupMaster> BorGroupMasters { get; set; }
    }
}
