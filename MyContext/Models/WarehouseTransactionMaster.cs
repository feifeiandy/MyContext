using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseTransactionMaster
    {
        public string WarehouseTransactionNumber { get; set; }
        public int BillId { get; set; }
        public int Status { get; set; }
        public string CreateUser { get; set; }
        public string CreateUserName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string ConfirmUser { get; set; }
        public string ConfirmUserName { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string AbolishUser { get; set; }
        public string AbolishUserName { get; set; }
        public Nullable<System.DateTime> AbolishTime { get; set; }
        public Nullable<int> PrintCount { get; set; }
    }
}
