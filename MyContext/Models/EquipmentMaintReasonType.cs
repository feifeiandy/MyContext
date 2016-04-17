using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class EquipmentMaintReasonType
    {
        public EquipmentMaintReasonType()
        {
            this.EquipmentMaintReasons = new List<EquipmentMaintReason>();
        }

        public string MaintReasonTypeCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<EquipmentMaintReason> EquipmentMaintReasons { get; set; }
    }
}
