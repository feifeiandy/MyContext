using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class ManuPlanTaskBatchTransDetail
    {
        public int Id { get; set; }
        public string ManuPlanTaskNumber { get; set; }
        public int ManuPlanTaskBatchId { get; set; }
        public string InvmasCode { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public int InOutType { get; set; }
        public decimal TransCount { get; set; }
        public System.DateTime TransTime { get; set; }
        public bool SyncStatus { get; set; }
        public virtual ManuPlanTask ManuPlanTask { get; set; }
        public virtual ManuPlanTaskBatch ManuPlanTaskBatch { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
