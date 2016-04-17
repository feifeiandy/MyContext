using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class RFIDTag
    {
        public RFIDTag()
        {
            this.CustomerRechargeInfors = new List<CustomerRechargeInfor>();
            this.CustomerRechargeRecords = new List<CustomerRechargeRecord>();
        }

        public int Id { get; set; }
        public string TagNumber { get; set; }
        public string TagId { get; set; }
        public string TagIdHex { get; set; }
        public int TagType { get; set; }
        public int TagFlag { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string RegisterUser { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<CustomerRechargeInfor> CustomerRechargeInfors { get; set; }
        public virtual ICollection<CustomerRechargeRecord> CustomerRechargeRecords { get; set; }
    }
}
