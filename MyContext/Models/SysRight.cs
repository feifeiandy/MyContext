using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysRight
    {
        public SysRight()
        {
            this.SysMenus = new List<SysMenu>();
            this.SysRoles = new List<SysRole>();
        }

        public string RightCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> Stopped { get; set; }
        public virtual ICollection<SysMenu> SysMenus { get; set; }
        public virtual ICollection<SysRole> SysRoles { get; set; }
    }
}
