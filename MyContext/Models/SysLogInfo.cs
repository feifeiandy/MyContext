using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysLogInfo
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public System.DateTime LogTime { get; set; }
        public int LogType { get; set; }
        public string Operate { get; set; }
        public string ModuleCode { get; set; }
        public string OperateIp { get; set; }
        public string OperateMac { get; set; }
    }
}
