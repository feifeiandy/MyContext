using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class ManuPlanTaskBom
    {
        public int Id { get; set; }
        public string ManPlanTaskNumber { get; set; }
        public string InvmasCode { get; set; }
        public Nullable<decimal> RequireQuantity { get; set; }
        public Nullable<decimal> RealQuantity { get; set; }
        public virtual ManuPlanTask ManuPlanTask { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
