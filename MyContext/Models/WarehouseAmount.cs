using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseAmount
    {
        public int Id { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal CurrentAmount { get; set; }
        public string GrainCharacterCode { get; set; }
        public Nullable<decimal> InAmount { get; set; }
        public Nullable<decimal> InAmountNotConfirm { get; set; }
        public Nullable<decimal> OutAmount { get; set; }
        public Nullable<decimal> OutAmountNotConfirm { get; set; }
        public Nullable<decimal> ExpectationInAmount { get; set; }
        public Nullable<decimal> ExpectationOutAmount { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<System.DateTime> LastInDate { get; set; }
        public Nullable<System.DateTime> LastOutDate { get; set; }
        public string DistrictCode { get; set; }
        public byte[] RowVersion { get; set; }
        public virtual District District { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
