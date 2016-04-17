using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SampleDetail
    {
        public SampleDetail()
        {
            this.AssayDetails = new List<AssayDetail>();
        }

        public int Id { get; set; }
        public string SampleNumber { get; set; }
        public virtual ICollection<AssayDetail> AssayDetails { get; set; }
        public virtual SampleMaster SampleMaster { get; set; }
    }
}
