using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class DeductIndex
    {
        public int DeductCode { get; set; }
        public string Name { get; set; }
        public int DeductType { get; set; }
        public bool Stopped { get; set; }
        public string QualityCode { get; set; }
    }
}
