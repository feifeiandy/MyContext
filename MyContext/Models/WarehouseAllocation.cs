using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseAllocation
    {
        public WarehouseAllocation()
        {
            this.ManuPlanTaskBatchInWarehouses = new List<ManuPlanTaskBatchInWarehouse>();
            this.ManuPlanTaskBatchOutWarehouses = new List<ManuPlanTaskBatchOutWarehouse>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseBatchMasters = new List<WarehouseBatchMaster>();
            this.WarehouseCarryOverByDays = new List<WarehouseCarryOverByDay>();
            this.WarehouseCarryOverByMonths = new List<WarehouseCarryOverByMonth>();
        }

        public string AllocationCode { get; set; }
        public string Name { get; set; }
        public string WarehouseCode { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public bool NeedBatchManager { get; set; }
        public virtual ICollection<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseBatchMaster> WarehouseBatchMasters { get; set; }
        public virtual ICollection<WarehouseCarryOverByDay> WarehouseCarryOverByDays { get; set; }
        public virtual ICollection<WarehouseCarryOverByMonth> WarehouseCarryOverByMonths { get; set; }
    }
}
