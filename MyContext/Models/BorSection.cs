using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorSection
    {
        public BorSection()
        {
            this.BomDetailSections = new List<BomDetailSection>();
            this.BorLineSections = new List<BorLineSection>();
            this.BorSectionEquipments = new List<BorSectionEquipment>();
            this.BomSubsidiaries = new List<BomSubsidiary>();
        }

        public string BorSectionCode { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<BomDetailSection> BomDetailSections { get; set; }
        public virtual ICollection<BorLineSection> BorLineSections { get; set; }
        public virtual ICollection<BorSectionEquipment> BorSectionEquipments { get; set; }
        public virtual ICollection<BomSubsidiary> BomSubsidiaries { get; set; }
    }
}
