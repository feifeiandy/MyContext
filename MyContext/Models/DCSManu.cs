using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class DCSManu
    {
        public int Id { get; set; }
        public string WarehouseTransactionNumber { get; set; }
        public string InvmasCode { get; set; }
        public string OutWarehouseCode { get; set; }
        public string OutAllocationCode { get; set; }
        public string InWarehouseCode { get; set; }
        public string InAllocationCode { get; set; }
        public Nullable<decimal> ManuCount { get; set; }
        public Nullable<System.DateTime> ManuTime { get; set; }
        public string ManuPlanNum { get; set; }
        public bool SyncStatus { get; set; }
        public string BomNum { get; set; }
    }
}
