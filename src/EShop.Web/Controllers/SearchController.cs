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
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        private int sPageSize = 8;

        private IOtherTypeManager otManager = new OtherTypeManager();
        public ActionResult Index(int? pageIndex,int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? sPageSize;
            string content = String.Empty;
            if (Session["searchText_s"] != null && Session["searchText_s"].ToString() != "")
                content = (string)Session["searchText_s"];
            int count = otManager.GetCount("hotSearch", content);
            List<OtherType> list = otManager.PagingFindOtherType("hotSearch", content, index, size);
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        [HttpGet]
        public ActionResult DelContent(string ID)
        {
            bool result = otManager.DeleteOtherType(ID);
            if (!result)
                TempData["mess"] = "删除热搜内容操作失败！";
            return Redirect("Index");
        }

        public ActionResult AddSearch()
        {
            int count = otManager.GetCount("hotSearch", null);
            ViewBag.Code = count + 1000;
            return View();
        }
      
        [HttpPost]
        public ActionResult AddNewSearch(int typeCode, string typeContent)
        {
            OtherType ot = new OtherType()
            {
                Id = Guid.NewGuid().ToString(),
                TypeName = "hotSearch",
                TypeCode = typeCode,
                TypeContent = typeContent 
            };
            bool success = otManager.InsertOtherType(ot);//.InsertBookType(bt);//.AddInfo(upi);
            if (success)
                TempData["mess"] = "成功添加新内容：" + ot.TypeContent;
            return Redirect("Index");
        }

        /// <summary>
        /// 修改图书类型页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult EditSearch(string ID)
        {
            OtherType ot = otManager.FindById(ID);
            return View(ot);
        }
        [HttpPost]
        public ActionResult EditSearchInfo(string searchId, string typeContent)
        {
            OtherType ot = otManager.FindById(searchId);
            ot.TypeContent = typeContent;
            bool result = otManager.UpdateOtherType(ot);
            if (result)
                TempData["mess"] = "内容‘" + typeContent + "’修改成功";
            return Redirect("Index");
        }
        [AllowAnonymous]
        public ActionResult FindBySearchText(string content)
        {
            Session["searchText_t"] = content;
            return Redirect("Index");
        }

    }
}
