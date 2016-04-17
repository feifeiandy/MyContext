using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class EquipmentMaintReason
    {
        public EquipmentMaintReason()
        {
            this.EquipmentTypes = new List<EquipmentType>();
        }

        public string MaintReasonCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public string MaintReasonTypeCode { get; set; }
        public bool Stopped { get; set; }
        public virtual EquipmentMaintReasonType EquipmentMaintReasonType { get; set; }
        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
    }
}
