using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BomSubsidiary
    {
        public BomSubsidiary()
        {
            this.BorSections = new List<BorSection>();
        }

        public string BomSubsidiaryCode { get; set; }
        public string BomMasterCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal StandardQuantity { get; set; }
        public virtual BomMaster BomMaster { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
        public virtual ICollection<BorSection> BorSections { get; set; }
    }
}
