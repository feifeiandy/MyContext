using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BomDetailSection
    {
        public int Id { get; set; }
        public int BomDetailId { get; set; }
        public string BorSectionCode { get; set; }
        public decimal InputQuantity { get; set; }
        public decimal BadRate { get; set; }
        public virtual BomDetail BomDetail { get; set; }
        public virtual BorSection BorSection { get; set; }
    }
}
