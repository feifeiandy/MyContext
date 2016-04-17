using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BomMaster
    {
        public BomMaster()
        {
            this.BomDetails = new List<BomDetail>();
            this.BomSubsidiaries = new List<BomSubsidiary>();
            this.ManuPlanTasks = new List<ManuPlanTask>();
        }

        public string BomCode { get; set; }
        public string Name { get; set; }
        public string InvmasCode { get; set; }
        public decimal Outputs { get; set; }
        public int Version { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public Nullable<int> MixTime { get; set; }
        public virtual ICollection<BomDetail> BomDetails { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
        public virtual ICollection<BomSubsidiary> BomSubsidiaries { get; set; }
        public virtual ICollection<ManuPlanTask> ManuPlanTasks { get; set; }
    }
}
