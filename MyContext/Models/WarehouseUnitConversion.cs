using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseUnitConversion
    {
        public string FromUnitCode { get; set; }
        public string ToUnitCode { get; set; }
        public Nullable<decimal> ConversionRate { get; set; }
        public virtual WarehouseUnit WarehouseUnit { get; set; }
        public virtual WarehouseUnit WarehouseUnit1 { get; set; }
    }
}
