using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            this.BorSectionEquipments = new List<BorSectionEquipment>();
        }

        public string EquipmentCode { get; set; }
        public string EquipmentTypeCode { get; set; }
        public string Name { get; set; }
        public string EquipmentModel { get; set; }
        public string EquipmentSpec { get; set; }
        public string Remark { get; set; }
        public Nullable<int> WorkTimeRate { get; set; }
        public Nullable<int> WorkTimeMaintain { get; set; }
        public Nullable<int> WorkTimeSingle { get; set; }
        public Nullable<int> WorkTimeTotal { get; set; }
        public int Status { get; set; }
        public virtual ICollection<BorSectionEquipment> BorSectionEquipments { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
    }
}
