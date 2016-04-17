using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorLineSection
    {
        public string BorLineCode { get; set; }
        public string BorSectionCode { get; set; }
        public int Sequence { get; set; }
        public virtual BorLine BorLine { get; set; }
        public virtual BorSection BorSection { get; set; }
    }
}
