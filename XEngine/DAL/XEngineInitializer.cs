using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Models;

namespace XEngine.DAL
{
    public class XEngineInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<XEngineContext>
    {
        protected override void Seed(XEngineContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser{ID=1,Name="ZS",CName="张三",Email="zs@xengine.com",
                    Password="1",ModifiedDate=DateTime.Now},
                new SysUser{ID=2,Name="LS",CName="李四",Email="ls@xengine.com",
                    Password="1",ModifiedDate=DateTime.Now},
                new SysUser{ID=3,Name="WW",CName="王五",Email="ww@xengine.com",
                    Password="1",ModifiedDate=DateTime.Now}
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRoles = new List<SysRole>
            {
                new SysRole{ID=1,Name="Administrators",CName="管理员",
                    Description="Administrtors have full authorization to perform system administration.",
                    ModifiedDate=DateTime.Now},
                new SysRole{ID=2,Name="General Users",CName="一般用户",
                    Description="General Users can access the shared data they are authorized for.",
                    ModifiedDate=DateTime.Now},
            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

            var sysUserRoles = new List<SysUserRole>
            {
                new SysUserRole{SysUserID=1,SysRoleID=1,ModifiedDate=DateTime.Now},
                new SysUserRole{SysUserID=1,SysRoleID=2,ModifiedDate=DateTime.Now},
                new SysUserRole{SysUserID=2,SysRoleID=1,ModifiedDate=DateTime.Now},
                new SysUserRole{SysUserID=3,SysRoleID=2,ModifiedDate=DateTime.Now},
            };
            sysUserRoles.ForEach(s => context.SysUserRoles.Add(s));
            context.SaveChanges();

            //var sysOrganizations = new List<SysOrganization>
            //{
            //    new SysOrganization{ID=1,Name="XEngine",Description="示例公司",Type=1,ChargeLeader="1",Leader="2",ParentID=0,Status=0,ModifiedDate=DateTime.Now},
            //    new SysOrganization{ID=2,Name="研发部",Description="示例部门",Type=2,ChargeLeader="1",Leader="2",ParentID=1,Status=0,ModifiedDate=DateTime.Now}
            //};
            //sysOrganizations.ForEach(s => context.SysOrganizations.Add(s));
            //context.SaveChanges();

            //var sysMenus = new List<SysMenu>
            //{
            //    new SysMenu{ID=1, Name="MenuTest",Description="根菜单",Action="",Controller="",IconImage="", MenuType=MenuTypeOption.Top,ModifiedDate=DateTime.Now},
            //    new SysMenu{ID=2, ParentID=1, Name="Level 1a",Description="第一层菜单1",Action="",Controller="",IconImage="", MenuType=MenuTypeOption.Submenu,ModifiedDate=DateTime.Now},
            //    new SysMenu{ID=3, ParentID=1, Name="Level 1b",Description="第一层菜单2",Action="",Controller="",IconImage="", MenuType=MenuTypeOption.Submenu,ModifiedDate=DateTime.Now},
            //    new SysMenu{ID=4, ParentID=2, Name="Level 2",Description="第二层菜单1",Action="",Controller="",IconImage="", MenuType=MenuTypeOption.Submenu,ModifiedDate=DateTime.Now}

            //};
            //sysMenus.ForEach(s => context.SysMenus.Add(s));
            //context.SaveChanges();
        }
    }
}