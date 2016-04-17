using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class PlanTaskTypeInOutDetail
    {
        public string PlanTaskTypeCode { get; set; }
        public int InOutType { get; set; }
        public bool NeedVehicle { get; set; }
        public bool NeedBorLine { get; set; }
        public Nullable<bool> BorWeight { get; set; }
        public bool NeedWorkplace { get; set; }
        public bool NeedDuty { get; set; }
        public Nullable<int> WeightMode { get; set; }
        public bool NeedSettle { get; set; }
        public bool NeedCheckOut { get; set; }
        public virtual PlanTaskType PlanTaskType { get; set; }
    }
}
