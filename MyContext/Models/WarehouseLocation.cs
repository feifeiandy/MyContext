using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseLocation
    {
        public string WarehouseCode { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int DrawWidth { get; set; }
        public int DrawHeight { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
