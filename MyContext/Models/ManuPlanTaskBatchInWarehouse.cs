using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class ManuPlanTaskBatchInWarehouse
    {
        public int Id { get; set; }
        public int ManuPlanTaskBatchId { get; set; }
        public Nullable<int> Seq { get; set; }
        public string InvmasCode { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public Nullable<decimal> PlanAmount { get; set; }
        public virtual ManuPlanTaskBatch ManuPlanTaskBatch { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
