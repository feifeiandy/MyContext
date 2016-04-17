using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseTransactionDetail
    {
        public int Id { get; set; }
        public string WarehouseTransactionNumber { get; set; }
        public int Seq { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal TransCount { get; set; }
        public string ToWarehouseCode { get; set; }
        public string ToAllocationCode { get; set; }
    }
}
