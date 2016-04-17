using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class DCSPurchase
    {
        public int Id { get; set; }
        public string WarehouseTransactionNumber { get; set; }
        public string InvmasCode { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string ShipNo { get; set; }
        public Nullable<decimal> InCount { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public bool SyncStatus { get; set; }
    }
}
