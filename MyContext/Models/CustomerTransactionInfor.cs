using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class CustomerTransactionInfor
    {
        public int Id { get; set; }
        public int BusinessCustomerId { get; set; }
        public string InvmasCode { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string WarehouseCode { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<int> TransType { get; set; }
        public virtual BusinessCustomer BusinessCustomer { get; set; }
    }
}
