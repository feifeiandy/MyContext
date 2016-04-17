using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class District
    {
        public District()
        {
            this.WarehouseAmounts = new List<WarehouseAmount>();
        }

        public string DistrictCode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
    }
}
