using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysBillNo
    {
        public int Id { get; set; }
        public string BillName { get; set; }
        public Nullable<int> MaxNo { get; set; }
        public string MaxDate { get; set; }
        public string Prefix { get; set; }
        public int NumBit { get; set; }
        public bool UseCompanyCode { get; set; }
        public bool UseDepartmentCode { get; set; }
        public string Style { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<int> State { get; set; }
        public string System { get; set; }
        public Nullable<int> TransType { get; set; }
        public bool IsTrans { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
