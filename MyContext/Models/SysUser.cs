using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysUser
    {
        public SysUser()
        {
            this.Warehouses = new List<Warehouse>();
            this.Warehouses1 = new List<Warehouse>();
        }

        public string UserCode { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool NeedChangePassword { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public int Sex { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string OfficialPhone { get; set; }
        public string Position { get; set; }
        public bool Stopped { get; set; }
        public bool IsLeader { get; set; }
        public string Remark { get; set; }
        public bool IsOnline { get; set; }
        public byte[] Picture { get; set; }
        public string DepartmentCode { get; set; }
        public virtual SysDepartment SysDepartment { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Warehouse> Warehouses1 { get; set; }
    }
}
