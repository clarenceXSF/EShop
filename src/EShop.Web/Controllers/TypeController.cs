using EShop.Common;
using EShop.BLL;
using EShop.BLL.Manager;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace EShop.Web.Controllers
{
    public class TypeController : Controller
    {
        //
        // GET: /Type/

        private int alPageSize = 4;//列表页显示行数

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
            if (Session["searchText_t"] != null && Session["searchText_t"].ToString() != "")
                content = (string)Session["searchText_t"];
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
        public ActionResult delUploadImg(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string runPath = "~/Images/bookType/";
                string userImg = Server.MapPath(runPath);//图书类型导航菜单显示
                string fileName;
                if (System.IO.File.Exists(userImg + file.FileName))
                {
                    string extension = Path.GetExtension(file.FileName);//上传文件的拓展名
                    //如果存在同名文件则使用Guid生成的名字
                    fileName = Guid.NewGuid().ToString() + extension;
                }
                else
                {
                    fileName = file.FileName;
                }
                Session["TypeImgPath"] = runPath.Substring(1, runPath.Length - 1) + fileName;
                file.SaveAs(userImg + fileName);//保存上传的图片
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public ActionResult AddNewType(string typeCode, string typeName)
        {
            string imgSrc = String.Empty;
            if(Session["TypeImgPath"]!= null && Session["TypeImgPath"].ToString() != "")
                imgSrc = (string)Session["TypeImgPath"];
            BookType bt = new BookType()
            {
                Id = Guid.NewGuid().ToString(),
                TypeCode = typeCode,
                TypeName = typeName,
                ImgSrc = imgSrc
            };
            Session["TypeImgPath"] = null;
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
            BookType bt = btManager.FindById(ID);
            return View(bt);
        }
        [HttpPost]
        public ActionResult EditTypeInfo(string typeId, string typeCode, string typeName)
        {
            BookType bt = btManager.FindById(typeId);
            bt.TypeCode = typeCode;
            bt.TypeName = typeName;
            if (Session["TypeImgPath"] != null && Session["TypeImgPath"].ToString() != "")
            {
                bt.ImgSrc = (string)Session["TypeImgPath"];
                Session["TypeImgPath"] = null;
            }
            bool result = btManager.UpdateBookType(bt);
            if (result)
                TempData["mess"] = "类型‘" + bt.TypeName + "’修改成功";
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
