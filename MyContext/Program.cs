﻿using MyContext.Models;
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
            #region ToList() Local 的区别
            aisino_mesContext MyContext = new aisino_mesContext();
            int listcont = MyContext.SysRoles.ToList().Count();
            Console.WriteLine("添加实体之前" + listcont);

            SysRole sys = new SysRole();
            sys.RoleCode = "121";
            sys.Name = "121";
            sys.Remark = "121";
            sys.Stopped = false;

            MyContext.SysRoles.Add(sys);
            int listcont2 = MyContext.SysRoles.ToList().Count();
            int listcont3 = MyContext.SysRoles.Local.Count();
            Console.WriteLine("添加实体之前" + listcont2);
            Console.WriteLine("添加实体之前" + listcont3);
            Console.Read(); 
            #endregion



        }
    }
}
