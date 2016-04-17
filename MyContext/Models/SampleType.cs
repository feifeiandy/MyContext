using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SampleType
    {
        public SampleType()
        {
            this.SampleMasters = new List<SampleMaster>();
        }

        public string SampleTypeCode { get; set; }
        public string Name { get; set; }
        public bool NeedSaved { get; set; }
        public Nullable<int> SavedCount { get; set; }
        public int SampleCount { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<SampleMaster> SampleMasters { get; set; }
    }
}
