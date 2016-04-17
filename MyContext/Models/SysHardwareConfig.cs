using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysHardwareConfig
    {
        public int Id { get; set; }
        public string MacAddress { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public string ConfigFile { get; set; }
    }
}
