using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysCode
    {
        public int Id { get; set; }
        public int CodeType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
    }
}
