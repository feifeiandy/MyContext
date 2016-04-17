using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class LipaDensityInfo
    {
        public string InvmasCode { get; set; }
        public int StandardTemperature { get; set; }
        public decimal StandardDensity { get; set; }
        public Nullable<decimal> ChangeDensity { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
