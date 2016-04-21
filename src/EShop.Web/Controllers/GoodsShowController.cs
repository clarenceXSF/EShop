using EShop.BLL;
using EShop.BLL.Manager;
using EShop.Common;
using EShop.Models;
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
        private int showSize = 16;
        private IBookInfoManager bookManager = new BookInfoManager();
        private IBookTypeManager typeManager = new BookTypeManager();
        public ActionResult Index(string keyword, string type, int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? showSize;
            int count = 0;
            List<BookInfo> list = new List<BookInfo>();
            string content = String.Empty;
            if (!string.IsNullOrEmpty(keyword))
            {
                content = keyword;
                ViewBag.Content = keyword;
                Session["searchText_g"] = null;
            }
            if (Session["searchText_g"] != null && Session["searchText_g"].ToString() != "")
                content = (string)Session["searchText_g"];

            if (!string.IsNullOrEmpty(type))
            {
                BookType t = typeManager.FindById(type);
                ViewBag.Content = t.TypeName;
                count = bookManager.GetTypeCount(type);
                list = bookManager.FindByType(type, index, size);
            }
            else
            {
                count = bookManager.GetCount(content);
                list = bookManager.PagingFindBookInfo(content, index, size);
            }
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
       
    }
}
