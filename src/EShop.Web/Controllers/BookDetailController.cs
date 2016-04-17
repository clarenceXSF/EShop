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
    /// <summary>
    /// 前台界面：图书详细
    /// </summary>
    public class BookDetailController : Controller
    {
        //
        // GET: /BookDetail/
        private IBookInfoManager bookManager = new BookInfoManager();
        public ActionResult Index(string bookid)
        {
            BookInfo bi = bookManager.FindById(bookid);
            return View(bi);
        }

    }
}
