using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            this.ManuPlanTaskBatchInWarehouses = new List<ManuPlanTaskBatchInWarehouse>();
            this.ManuPlanTaskBatchOutWarehouses = new List<ManuPlanTaskBatchOutWarehouse>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
            this.WarehouseAllocations = new List<WarehouseAllocation>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseBatchMasters = new List<WarehouseBatchMaster>();
            this.WarehouseCarryOverByDays = new List<WarehouseCarryOverByDay>();
            this.WarehouseCarryOverByMonths = new List<WarehouseCarryOverByMonth>();
            this.SysUsers = new List<SysUser>();
            this.SysUsers1 = new List<SysUser>();
        }

        public string WarehouseCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int Status { get; set; }
        public string WarehouseTypeCode { get; set; }
        public string InvmasCharacterCode { get; set; }
        public bool UseLocation { get; set; }
        public bool Virtuality { get; set; }
        public string Remark { get; set; }
        public bool NeedBatchManager { get; set; }
        public virtual ICollection<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
        public virtual WarehouseInvmasCharacter WarehouseInvmasCharacter { get; set; }
        public virtual ICollection<WarehouseAllocation> WarehouseAllocations { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseBatchMaster> WarehouseBatchMasters { get; set; }
        public virtual ICollection<WarehouseCarryOverByDay> WarehouseCarryOverByDays { get; set; }
        public virtual ICollection<WarehouseCarryOverByMonth> WarehouseCarryOverByMonths { get; set; }
        public virtual WarehouseDetail WarehouseDetail { get; set; }
        public virtual WarehouseLocation WarehouseLocation { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
        public virtual ICollection<SysUser> SysUsers1 { get; set; }
    }
}
