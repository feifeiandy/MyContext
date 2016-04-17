using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysCompanyInfo
    {
        public string CompanyCode { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string Symbol { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string DepositBank { get; set; }
        public string BankAccount { get; set; }
        public string TaxNo { get; set; }
        public Nullable<decimal> Capital { get; set; }
        public Nullable<decimal> Capacity { get; set; }
        public Nullable<int> DepotNum { get; set; }
        public Nullable<decimal> FloorSurface { get; set; }
        public Nullable<int> EmployeeNum { get; set; }
        public Nullable<int> DockNum { get; set; }
        public string Remark { get; set; }
    }
}
