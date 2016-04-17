using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class QualityGradeIndex
    {
        public int Id { get; set; }
        public string GradeCode { get; set; }
        public int InvmasQualityIndexId { get; set; }
        public decimal StandardValue { get; set; }
        public Nullable<decimal> StandardDownValue { get; set; }
        public int CompareType { get; set; }
        public int Seq { get; set; }
        public Nullable<int> NextCompareFlag { get; set; }
        public bool Stopped { get; set; }
    }
}
