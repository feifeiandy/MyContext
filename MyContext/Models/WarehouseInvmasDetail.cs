using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseInvmasDetail
    {
        public string InvmasCode { get; set; }
        public bool NeedBatch { get; set; }
        public Nullable<int> BatchPrinciple { get; set; }
        public bool NeedSafetyStock { get; set; }
        public Nullable<decimal> SafetyStock { get; set; }
        public bool NeedUpperBoundStock { get; set; }
        public Nullable<decimal> UpperBoundStock { get; set; }
        public Nullable<int> BatchKeepPeriod { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
