using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class AssayMasterResult
    {
        public int Id { get; set; }
        public string AssayNumber { get; set; }
        public int InvmasQualityIndexId { get; set; }
        public Nullable<decimal> TestValue { get; set; }
        public string TestText { get; set; }
        public bool TestResult { get; set; }
        public virtual AssayMaster AssayMaster { get; set; }
    }
}
