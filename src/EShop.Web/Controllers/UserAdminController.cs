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
            if (string.IsNullOrEmpty(Session["loginName"].ToString()))
                return RedirectToAction("UserIndex", "Account");
            return View();
        }

    }
}
