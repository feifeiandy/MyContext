using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorSectionEquipment
    {
        public string BorSectionCode { get; set; }
        public string EquipmentCode { get; set; }
        public int Sequence { get; set; }
        public string EquipmentOperateKind { get; set; }
        public string EquipmentOperateRemark { get; set; }
        public virtual BorSection BorSection { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
