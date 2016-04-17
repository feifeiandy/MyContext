using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            this.Equipments = new List<Equipment>();
            this.EquipmentMaintReasons = new List<EquipmentMaintReason>();
        }

        public string EquipmentTypeCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public bool IsWeight { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<EquipmentMaintReason> EquipmentMaintReasons { get; set; }
    }
}
