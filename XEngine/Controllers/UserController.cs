using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.DAL;
using XEngine.Models;
using XEngine.Repositories;

namespace XEngine.Controllers
{
    public class UserController : Controller
    {
        private UnitOfWork unitOdfWiork = new UnitOfWork();
        //private ISysUserRepository userRepository
        //    = new SysUserRepository(new XEngineContext());
        //// GET: User
        //public ActionResult Index()
        //{
        //    var user = userRepository.GetUsers();
        //    return View(user);
        //}
        //private IGenericRepository<SysUser> userRepository
        //    = new GenericRepository<SysUser>(new XEngineContext());
        //
        //Get:/User/
        public ActionResult Index()
        {
            var users = unitOdfWiork.SysUserRepository.Get(orderBy:Q=>Q.OrderBy(u=>u.Name));
            return View(users);
        }
    }
}