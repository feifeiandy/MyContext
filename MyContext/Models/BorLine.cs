using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class BorLine
    {
        public BorLine()
        {
            this.BorGroupMasters = new List<BorGroupMaster>();
            this.BorLineSections = new List<BorLineSection>();
        }

        public string BorLineCode { get; set; }
        public string BorTypeCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<BorGroupMaster> BorGroupMasters { get; set; }
        public virtual BorType BorType { get; set; }
        public virtual ICollection<BorLineSection> BorLineSections { get; set; }
    }
}
