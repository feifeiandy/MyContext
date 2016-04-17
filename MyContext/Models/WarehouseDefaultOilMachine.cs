using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseDefaultOilMachine
    {
        public int ID { get; set; }
        public string OilMachineIp { get; set; }
        public string WarehouseCode { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
