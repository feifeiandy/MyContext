using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorType
    {
        public BorType()
        {
            this.BorLines = new List<BorLine>();
        }

        public string BorTypeCode { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<BorLine> BorLines { get; set; }
    }
}
