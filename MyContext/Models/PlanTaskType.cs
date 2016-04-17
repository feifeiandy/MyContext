using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class PlanTaskType
    {
        public PlanTaskType()
        {
            this.ManuPlanTasks = new List<ManuPlanTask>();
        }

        public string PlanTaskTypeCode { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
        public int BillType { get; set; }
        public int PlanTaskMode { get; set; }
        public bool AutoThrowQuality { get; set; }
        public bool NeedBomWarehouse { get; set; }
        public bool AutoBomWarehouse { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<ManuPlanTask> ManuPlanTasks { get; set; }
        public virtual PlanTaskTypeInOutDetail PlanTaskTypeInOutDetail { get; set; }
    }
}
