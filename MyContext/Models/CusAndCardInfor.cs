using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class CusAndCardInfor
    {
        public int Id { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> CusRechargeInforId { get; set; }
        public Nullable<int> CusRecordsId { get; set; }
        public Nullable<int> CusTransInforId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> RechargeDate { get; set; }
        public string RechargeYear { get; set; }
        public string RechargeMonth { get; set; }
        public string TargetInvmasCode { get; set; }
        public string BaseInvmasCode { get; set; }
        public Nullable<decimal> TargetPrice { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<decimal> TargetWeight { get; set; }
        public Nullable<decimal> BaseWeight { get; set; }
        public Nullable<int> BehaviorType { get; set; }
        public Nullable<int> RechargeType { get; set; }
        public Nullable<decimal> TargetBalance { get; set; }
        public Nullable<decimal> BaseBalance { get; set; }
        public string RfTagId { get; set; }
        public Nullable<bool> IsCurrent { get; set; }
        public Nullable<System.DateTime> RechargeDatetime { get; set; }
        public Nullable<decimal> RechargeOrSaleWeight { get; set; }
        public string BaseInvmasName { get; set; }
        public string TargetInvmasName { get; set; }
    }
}
