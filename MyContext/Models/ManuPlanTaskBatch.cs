using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class ManuPlanTaskBatch
    {
        public ManuPlanTaskBatch()
        {
            this.ManuPlanTaskBatchInWarehouses = new List<ManuPlanTaskBatchInWarehouse>();
            this.ManuPlanTaskBatchOutWarehouses = new List<ManuPlanTaskBatchOutWarehouse>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
        }

        public int Id { get; set; }
        public string ManuPlanTaskNumber { get; set; }
        public int Seq { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public Nullable<decimal> PlanQuantity { get; set; }
        public Nullable<decimal> BatchQuantity { get; set; }
        public string BorLineCode { get; set; }
        public string BorSectionCode { get; set; }
        public int Status { get; set; }
        public bool SyncStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public virtual ManuPlanTask ManuPlanTask { get; set; }
        public virtual ICollection<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
    }
}
