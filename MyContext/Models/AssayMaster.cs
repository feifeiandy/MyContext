using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class AssayMaster
    {
        public AssayMaster()
        {
            this.AssayDetails = new List<AssayDetail>();
            this.AssayMasterResults = new List<AssayMasterResult>();
        }

        public string AssayNumber { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string ConfirmUser { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public bool AssayResult { get; set; }
        public int Status { get; set; }
        public string PlanTaskBatchNumber { get; set; }
        public virtual ICollection<AssayDetail> AssayDetails { get; set; }
        public virtual ICollection<AssayMasterResult> AssayMasterResults { get; set; }
    }
}
