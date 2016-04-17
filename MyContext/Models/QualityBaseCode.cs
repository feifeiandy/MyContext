using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class QualityBaseCode
    {
        public int Id { get; set; }
        public string CodeType { get; set; }
        public string BaseCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
