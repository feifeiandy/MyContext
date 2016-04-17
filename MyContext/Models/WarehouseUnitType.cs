using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseUnitType
    {
        public WarehouseUnitType()
        {
            this.WarehouseUnits = new List<WarehouseUnit>();
        }

        public string UnitTypeCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<WarehouseUnit> WarehouseUnits { get; set; }
    }
}
