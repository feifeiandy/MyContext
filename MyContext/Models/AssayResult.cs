using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class AssayResult
    {
        public int Id { get; set; }
        public int AssayDetailId { get; set; }
        public int InvmasQualityIndexId { get; set; }
        public Nullable<decimal> TestValue { get; set; }
        public string TestText { get; set; }
        public bool TestResult { get; set; }
        public string AssayUser { get; set; }
        public System.DateTime AssayTime { get; set; }
        public bool IsReference { get; set; }
        public virtual AssayDetail AssayDetail { get; set; }
    }
}
