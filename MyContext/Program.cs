using MyContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContext
{
    class Program
    {
        static void Main(string[] args)
        {

            aisino_mesContext MyContext = new aisino_mesContext();
            //#region ToList() Local 的区别
            ////ToList每次查询数据库，不管内存中是否添加
            ////Local每次查询内存（后来添加的，和数据库本来有的，如果内存中标记删除，数据库中有则被过滤）
            //int listcont = MyContext.SysRoles.ToList().Count();
            //Console.WriteLine("添加实体之前" + listcont);

            //SysRole sys = new SysRole();
            //sys.RoleCode = "121";
            //sys.Name = "121";
            //sys.Remark = "121";
            //sys.Stopped = false;

            //MyContext.SysRoles.Add(sys);
            //int listcont2 = MyContext.SysRoles.ToList().Count();
            //int listcont3 = MyContext.SysRoles.Local.Count();
            //Console.WriteLine("添加实体之前" + listcont2);
            //Console.WriteLine("添加实体之前" + listcont3);
            //Console.Read();
            //#endregion


            //#region 集合中添加实体（外键相关），默认相关外键的表自动添加实体
            //SysRoleUser sysRoleUser = new SysRoleUser();
            //sysRoleUser.RoleCode = "121";
            //sysRoleUser.UserCode = "11";
            //sysRoleUser.SysRole = sys;
            //MyContext.SysRoleUsers.Add(sysRoleUser);
            //MyContext.SaveChanges();
            //#endregion


            //#region 级联删除 一对一
            //var a = MyContext.SysRoleUsers.Single(c => c.RoleCode == "121");
            //var b = MyContext.SysRoles.Find("121");
            //MyContext.SysRoles.Remove(b);
            //MyContext.SaveChanges();
            //#endregion

            //#region 级联删除 一对多
            //var wf = MyContext.SysRoles.Find("wf");
            //MyContext.Entry(wf).Collection("SysRights").Load();
            //MyContext.SysRoles.Remove(wf);
            //MyContext.SaveChanges(); 
            //#endregion
        }
    }
}
