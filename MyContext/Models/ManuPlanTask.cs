using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class ManuPlanTask
    {
        public ManuPlanTask()
        {
            this.ManuPlanTaskBatches = new List<ManuPlanTaskBatch>();
            this.ManuPlanTaskBoms = new List<ManuPlanTaskBom>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
        }

        public string ManuPlanTaskNumber { get; set; }
        public string PlanTaskTypeCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public string BomCode { get; set; }
        public string BorLineCode { get; set; }
        public string CreateUser { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string ReleaseUser { get; set; }
        public string ReleaseUserName { get; set; }
        public Nullable<System.DateTime> ReleaseTime { get; set; }
        public string AbolishUser { get; set; }
        public string AbolishUserName { get; set; }
        public Nullable<System.DateTime> AbolishTime { get; set; }
        public Nullable<System.DateTime> PlanStartTime { get; set; }
        public Nullable<System.DateTime> PlanFinishTime { get; set; }
        public Nullable<System.DateTime> RealStartTime { get; set; }
        public Nullable<System.DateTime> RealFinishTime { get; set; }
        public Nullable<decimal> PlanQuantity { get; set; }
        public Nullable<decimal> FinishQuantity { get; set; }
        public bool AutoThrowQuality { get; set; }
        public bool NeedBomWarehouse { get; set; }
        public bool AutoBomWarehouse { get; set; }
        public int Status { get; set; }
        public bool SyncStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public virtual BomMaster BomMaster { get; set; }
        public virtual PlanTaskType PlanTaskType { get; set; }
        public virtual ICollection<ManuPlanTaskBatch> ManuPlanTaskBatches { get; set; }
        public virtual ICollection<ManuPlanTaskBom> ManuPlanTaskBoms { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
    }
}
