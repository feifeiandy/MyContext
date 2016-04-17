using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class SysMenu
    {
        public SysMenu()
        {
            this.SysUserFavorites = new List<SysUserFavorite>();
            this.SysRights = new List<SysRight>();
            this.SysSubSystems = new List<SysSubSystem>();
        }

        public string MenuCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> ShowIndex { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Layer { get; set; }
        public string ModuleCode { get; set; }
        public string FunctionCode { get; set; }
        public byte[] BigImage { get; set; }
        public byte[] SmallImage { get; set; }
        public Nullable<bool> ShowImage { get; set; }
        public Nullable<bool> ShowText { get; set; }
        public string ControlType { get; set; }
        public string ImagePosition { get; set; }
        public string ParentCode { get; set; }
        public virtual SysFunction SysFunction { get; set; }
        public virtual SysModule SysModule { get; set; }
        public virtual ICollection<SysUserFavorite> SysUserFavorites { get; set; }
        public virtual ICollection<SysRight> SysRights { get; set; }
        public virtual ICollection<SysSubSystem> SysSubSystems { get; set; }
    }
}
