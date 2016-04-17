using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehousetransInfor
    {
        public int Id { get; set; }
        public Nullable<int> WarehousedetailId { get; set; }
        public string Transdocuments { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string TransYear { get; set; }
        public string TransMonth { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string InvmasCode { get; set; }
        public string InvmasName { get; set; }
        public Nullable<decimal> Transcount { get; set; }
        public Nullable<int> Transtype { get; set; }
        public Nullable<decimal> CurrentBalanceCount { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<decimal> TargetPrice { get; set; }
        public Nullable<bool> IsCurrent { get; set; }
        public Nullable<System.DateTime> TransDateTime { get; set; }
        public Nullable<bool> Virtuality { get; set; }
    }
}
