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
        private IBookTypeManager typeManager = new BookTypeManager();
        private IOtherTypeManager otherManager = new OtherTypeManager();
        private IRecommendManager recommendManager = new RecommendManager();
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindHotSearch()
        {
            List<OtherType> list = otherManager.PagingFindOtherType("hotSearch", string.Empty, 0, 8);
            return Json(list);
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
            List<string> list = bookManager.FindAuthor(9);
            return Json(list);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindTypeByName(string name)
        {
            BookType bt = typeManager.FindByName(name);
            return Json(bt);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindByType(string type)
        {
            List<BookInfo> list = bookManager.FindByType(type, 8);
            return Json(list);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindRecommend()
        {
            string search = string.Empty;
            int count = recommendManager.GetCount(search);
            List<RecommendView> list = recommendManager.PagingFindRecommend(search, 0, count);
            return Json(list);
        }
    }
}
