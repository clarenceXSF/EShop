using EShop.Common;
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
    public class TypeController : Controller
    {
        //
        // GET: /Type/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        private int alPageSize = 5;//列表页显示行数

        private IBookTypeManager btManager = new BookTypeManager();

        /// <summary>
        /// 图书类型列表页面 Index.cshtml
        /// </summary>
        /// <param name="pageIndex">第几页，由 ？pageIndex=* 传入</param>
        /// <param name="pageSize">每页记录数</param>
        /// <returns></returns>
        public ActionResult Index(int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? alPageSize;
            string content = String.Empty;
            if (Session["searchText"] != null && Session["searchText"].ToString() != "")
                content = (string)Session["searchText"];
            int count = btManager.GetCount(content); 
            List<BookType> list = btManager.PagingFindBookType(content, index, size);
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        [HttpGet]
        public ActionResult DelType(string ID)
        {
            bool result = btManager.DeleteBookType(ID);
            if (!result)
                TempData["mess"] = "删除类型操作失败！";
            return Redirect("Index");
        }

        /// <summary>
        /// 添加图书类型页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewType(BookType bt)
        {
            bool success = btManager.InsertBookType(bt);//.AddInfo(upi);
            if (success)
                TempData["mess"] = "成功添加新类型：" + bt.TypeName;
            return Redirect("Index");
        }

        /// <summary>
        /// 修改图书类型页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult EditType(string ID)
        {
            TempData["editTypeId"] = ID;
            BookType bt = btManager.FindById(ID);
            return View(bt);
        }
        [HttpPost]
        public ActionResult EditProjectInfo(BookType bt)
        {
            bool result = btManager.UpdateBookType(bt);
            if (result)
                TempData["mess"] = "类型‘" + bt.TypeName + "’修改成功";
            return Redirect("Index");
        }
        [AllowAnonymous]
        public ActionResult FindBySearchText(string content)
        {
            Session["searchText"] = content;
            return Redirect("Index");
        }

    }
}
