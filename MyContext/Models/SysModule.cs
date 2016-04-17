using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysModule
    {
        public SysModule()
        {
            this.SysFunctions = new List<SysFunction>();
            this.SysMenus = new List<SysMenu>();
        }

        public string ModuleCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public bool Stopped { get; set; }
        public virtual ICollection<SysFunction> SysFunctions { get; set; }
        public virtual ICollection<SysMenu> SysMenus { get; set; }
    }
}
