using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Web.Controllers
{
    /// <summary>
    /// 前台界面：用户会员中心
    /// </summary>
    public class UserAdminController : Controller
    {
        //
        // GET: /UserAdmin/

        public ActionResult Index()
        {
            if (Session["loginName"] != null && Session["loginName"].ToString() != "")
                return View();
            return RedirectToAction("UserIndex", "Account");
        }
        public ActionResult _first() 
        {
            return View();
        }
        public ActionResult _sorry(string title)
        {
            ViewBag.Title = title;
            return View();
        }
    }
}
