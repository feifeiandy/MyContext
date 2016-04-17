using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysDepartment
    {
        public SysDepartment()
        {
            this.SysDepartment1 = new List<SysDepartment>();
            this.SysUsers = new List<SysUser>();
        }

        public string DepartmentCode { get; set; }
        public string Name { get; set; }
        public int ShowIndex { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public bool IsRealy { get; set; }
        public string ParentCode { get; set; }
        public virtual ICollection<SysDepartment> SysDepartment1 { get; set; }
        public virtual SysDepartment SysDepartment2 { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
