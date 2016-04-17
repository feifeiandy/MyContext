using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseAmountTransDetail
    {
        public int Id { get; set; }
        public Nullable<int> BatchMasterId { get; set; }
        public string TransNumber { get; set; }
        public int TransDetailId { get; set; }
        public string TransDocuments { get; set; }
        public System.DateTime TransDate { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal TransCount { get; set; }
        public string GrainCharacterCode { get; set; }
        public Nullable<decimal> TransInCount { get; set; }
        public Nullable<decimal> TransOutCount { get; set; }
        public int TransType { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TransMoney { get; set; }
        public virtual GrainCharacter GrainCharacter { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual WarehouseBatchMaster WarehouseBatchMaster { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
