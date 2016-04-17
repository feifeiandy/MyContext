using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseBaseConfig
    {
        public int id { get; set; }
        public string ModuleCode { get; set; }
        public int DumpHistory { get; set; }
        public int DeleteHistory { get; set; }
        public int MonthCarryOverDate { get; set; }
    }
}
