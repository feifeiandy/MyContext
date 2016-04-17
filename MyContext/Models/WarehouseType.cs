using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseType
    {
        public WarehouseType()
        {
            this.WarehouseType1 = new List<WarehouseType>();
        }

        public string WarehouseTypeCode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<WarehouseType> WarehouseType1 { get; set; }
        public virtual WarehouseType WarehouseType2 { get; set; }
    }
}
