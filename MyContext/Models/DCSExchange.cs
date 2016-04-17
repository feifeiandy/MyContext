using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class DCSExchange
    {
        public int Id { get; set; }
        public string WarehouseTransactionNumber { get; set; }
        public string InvmasCode { get; set; }
        public string OutWarehouseCode { get; set; }
        public string OutAllocationCode { get; set; }
        public string InWarehouseCode { get; set; }
        public string InAllocationCode { get; set; }
        public Nullable<decimal> ExchangeCount { get; set; }
        public Nullable<System.DateTime> ExchangeTime { get; set; }
        public bool SyncStatus { get; set; }
    }
}
