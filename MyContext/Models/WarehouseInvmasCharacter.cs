using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class WarehouseInvmasCharacter
    {
        public WarehouseInvmasCharacter()
        {
            this.Warehouses = new List<Warehouse>();
            this.WarehouseInvmas = new List<WarehouseInvma>();
        }

        public string InvmasCharacterCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<WarehouseInvma> WarehouseInvmas { get; set; }
    }
}
