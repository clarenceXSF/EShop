using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Web.Controllers
{
    /// <summary>
    /// 前台界面：分类显示
    /// </summary>
    public class GoodsShowController : Controller
    {
        //
        // GET: /GoodsShow/

        public ActionResult Index()
        {
            return View();
        }

    }
}
