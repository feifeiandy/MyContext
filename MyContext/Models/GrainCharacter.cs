using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class GrainCharacter
    {
        public GrainCharacter()
        {
            this.GrainCharacter1 = new List<GrainCharacter>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
        }

        public string GrainCharacterCode { get; set; }
        public string Name { get; set; }
        public bool Stopped { get; set; }
        public string ParentCode { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<GrainCharacter> GrainCharacter1 { get; set; }
        public virtual GrainCharacter GrainCharacter2 { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
    }
}
