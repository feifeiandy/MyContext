using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysRoleUser
    {
        public string RoleCode { get; set; }
        public string UserCode { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}
