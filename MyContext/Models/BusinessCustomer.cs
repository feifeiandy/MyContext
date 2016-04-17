using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BusinessCustomer
    {
        public BusinessCustomer()
        {
            this.CustomerRechargeInfors = new List<CustomerRechargeInfor>();
            this.CustomerRechargeRecords = new List<CustomerRechargeRecord>();
            this.CustomerTransactionInfors = new List<CustomerTransactionInfor>();
        }

        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameShort { get; set; }
        public Nullable<int> CustomerType { get; set; }
        public string CustomerTypeDes { get; set; }
        public string Contact { get; set; }
        public string ContactID { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string DepositBank { get; set; }
        public string AccountNumber { get; set; }
        public string TaxNumber { get; set; }
        public string RegisteredAddress { get; set; }
        public string ShippingAddress { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public string PaymentMethodDes { get; set; }
        public Nullable<int> PaymentPeriods { get; set; }
        public string PaymentPeriodsDes { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsStopped { get; set; }
        public virtual ICollection<CustomerRechargeInfor> CustomerRechargeInfors { get; set; }
        public virtual ICollection<CustomerRechargeRecord> CustomerRechargeRecords { get; set; }
        public virtual ICollection<CustomerTransactionInfor> CustomerTransactionInfors { get; set; }
    }
}
