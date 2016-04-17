using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseDetail
    {
        public string WarehouseCode { get; set; }
        public Nullable<decimal> Capacity { get; set; }
        public string Structure { get; set; }
        public Nullable<System.DateTime> BuildupYear { get; set; }
        public Nullable<bool> HeatInsulation { get; set; }
        public Nullable<int> WindowNum { get; set; }
        public Nullable<int> DoorNum { get; set; }
        public Nullable<decimal> StorageHeight { get; set; }
        public Nullable<decimal> WallInnerLength { get; set; }
        public Nullable<decimal> WallInnerWidth { get; set; }
        public Nullable<decimal> WallOuterLength { get; set; }
        public Nullable<decimal> WallOuterWidth { get; set; }
        public Nullable<decimal> EaveHeight { get; set; }
        public Nullable<decimal> RoofHeight { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
