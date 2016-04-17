using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysRole
    {
        public SysRole()
        {
            this.SysRoleUsers = new List<SysRoleUser>();
            this.SysRights = new List<SysRight>();
        }

        public string RoleCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> Stopped { get; set; }
        public virtual ICollection<SysRoleUser> SysRoleUsers { get; set; }
        public virtual ICollection<SysRight> SysRights { get; set; }
    }
}
