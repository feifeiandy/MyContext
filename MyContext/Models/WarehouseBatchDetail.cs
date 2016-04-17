using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseBatchDetail
    {
        public int Id { get; set; }
        public int WarehouseBatchId { get; set; }
        public string TransCode { get; set; }
        public string TransBillType { get; set; }
        public int TransType { get; set; }
        public decimal TransCount { get; set; }
        public virtual WarehouseBatchMaster WarehouseBatchMaster { get; set; }
    }
}
