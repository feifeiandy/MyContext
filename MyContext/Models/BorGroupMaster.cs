using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorGroupMaster
    {
        public BorGroupMaster()
        {
            this.WarehouseInvmas = new List<WarehouseInvma>();
        }

        public string BorGroupCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public bool Stopped { get; set; }
        public string BorLineCode { get; set; }
        public virtual BorLine BorLine { get; set; }
        public virtual ICollection<WarehouseInvma> WarehouseInvmas { get; set; }
    }
}
