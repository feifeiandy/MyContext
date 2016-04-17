using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseCarryOverByMonth
    {
        public int Id { get; set; }
        public System.DateTime CarryOverMonth { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal LastAmount { get; set; }
        public decimal CurrentInAmount { get; set; }
        public decimal CurrentOutAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
