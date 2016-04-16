using EShop.BLL;
using EShop.BLL.Manager;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private IBookInfoManager bookManager = new BookInfoManager();
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindNewCreateBook()
        {
            List<BookInfo> list = bookManager.FindTopCreate(3);
            return Json(list);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindHotSaleBook()
        {
            List<BookInfo> list = bookManager.FindTopSale(4);
            return Json(list);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindAuthor()
        {
            List<string> list = bookManager.FindAuthor(10);
            return Json(list);
        }
    }
}
