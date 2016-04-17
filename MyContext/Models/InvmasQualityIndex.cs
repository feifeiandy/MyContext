using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class InvmasQualityIndex
    {
        public int Id { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public string QualityCode { get; set; }
        public Nullable<decimal> StandardValue { get; set; }
        public Nullable<decimal> StandardDownValue { get; set; }
        public Nullable<int> CompareType { get; set; }
        public string TextStandardValue { get; set; }
        public bool IsNecessary { get; set; }
        public bool Stopped { get; set; }
    }
}
