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
    public class SaleController : Controller
    {
        //
        // GET: /Sale/
        private int salePageSize = 8;
        private IBookSaleManager bsManager = new BookSaleManager();
        private ISaleDetailManager sdManager = new SaleDetailManager();
        public ActionResult Index(int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? salePageSize;
            string content = String.Empty;
            if (Session["searchText_s"] != null && Session["searchText_s"].ToString() != "")
                content = (string)Session["searchText_s"];
            int count = bsManager.GetCount(content);
            List<BookSaleView> list = bsManager.PagingFindBookSale(content, index, size);
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        public ActionResult Detail(string ID)
        {
            BookSaleView bs = bsManager.FindById(ID);//reManager.FindDetailById(ID);
            return View(bs);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult FindSaleDetail(string ID)
        {
            List<SaleDetailView> list = sdManager.FindSaleDetail(ID);
            return Json(list);
        }
    }
}
