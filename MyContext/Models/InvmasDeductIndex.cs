using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class InvmasDeductIndex
    {
        public int Id { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public string DeductCode { get; set; }
        public string GradeCode { get; set; }
        public decimal StandardValue { get; set; }
        public Nullable<bool> HasDefault { get; set; }
        public Nullable<int> DefaultType { get; set; }
        public Nullable<decimal> DefaultCount { get; set; }
        public bool IsAuto { get; set; }
        public Nullable<bool> IsIncrease { get; set; }
        public Nullable<decimal> IncreaseRate { get; set; }
        public Nullable<decimal> IncreaseStep { get; set; }
        public Nullable<decimal> IncreaseLimit { get; set; }
        public Nullable<int> IncreaseType { get; set; }
        public Nullable<decimal> DeductRate { get; set; }
        public Nullable<decimal> DeductStep { get; set; }
        public Nullable<decimal> DeductLimit { get; set; }
        public Nullable<int> DeductType { get; set; }
    }
}
