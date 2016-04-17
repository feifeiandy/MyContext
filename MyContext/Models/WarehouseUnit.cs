using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseUnit
    {
        public WarehouseUnit()
        {
            this.WarehouseInvmas = new List<WarehouseInvma>();
            this.WarehouseUnitConversions = new List<WarehouseUnitConversion>();
            this.WarehouseUnitConversions1 = new List<WarehouseUnitConversion>();
        }

        public string UnitCode { get; set; }
        public string ChineseName { get; set; }
        public string EnglishName { get; set; }
        public string UnitTypeCode { get; set; }
        public decimal Rate { get; set; }
        public virtual ICollection<WarehouseInvma> WarehouseInvmas { get; set; }
        public virtual WarehouseUnitType WarehouseUnitType { get; set; }
        public virtual ICollection<WarehouseUnitConversion> WarehouseUnitConversions { get; set; }
        public virtual ICollection<WarehouseUnitConversion> WarehouseUnitConversions1 { get; set; }
    }
}
