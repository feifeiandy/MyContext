using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BomDetail
    {
        public BomDetail()
        {
            this.BomDetailSections = new List<BomDetailSection>();
        }

        public int Id { get; set; }
        public string BomCode { get; set; }
        public string InvmasCode { get; set; }
        public int Index { get; set; }
        public decimal StandardQuantity { get; set; }
        public Nullable<int> StandardProportion { get; set; }
        public Nullable<decimal> BadRate { get; set; }
        public string BadRateExpression { get; set; }
        public virtual BomMaster BomMaster { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
        public virtual ICollection<BomDetailSection> BomDetailSections { get; set; }
    }
}
