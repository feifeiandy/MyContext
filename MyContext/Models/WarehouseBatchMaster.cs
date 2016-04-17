using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseBatchMaster
    {
        public WarehouseBatchMaster()
        {
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseBatchDetails = new List<WarehouseBatchDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public System.DateTime BeginTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public bool Finished { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseBatchDetail> WarehouseBatchDetails { get; set; }
    }
}
