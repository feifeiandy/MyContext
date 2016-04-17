using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SampleMaster
    {
        public SampleMaster()
        {
            this.SampleDetails = new List<SampleDetail>();
        }

        public string SampleNumber { get; set; }
        public string SampleTypeCode { get; set; }
        public string PlanTaskBatchNumber { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public virtual ICollection<SampleDetail> SampleDetails { get; set; }
        public virtual SampleType SampleType { get; set; }
    }
}
