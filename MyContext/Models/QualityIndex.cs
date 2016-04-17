using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class QualityIndex
    {
        public string QualityCode { get; set; }
        public string Name { get; set; }
        public bool IsCompare { get; set; }
        public string Unit { get; set; }
        public string ParentCode { get; set; }
        public bool Stopped { get; set; }
    }
}
