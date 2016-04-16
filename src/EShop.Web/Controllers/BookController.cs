using EShop.BLL;
using EShop.BLL.Manager;
using EShop.Common;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Web.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/
        private int biPageSize = 6;//列表页显示行数
        private IBookInfoManager bookManager = new BookInfoManager();
        public ActionResult Index(int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? biPageSize;
            string content = String.Empty;
            if (Session["searchText_b"] != null && Session["searchText_b"].ToString() != "")
                content = (string)Session["searchText_b"];
            int count = bookManager.GetCount(content);
            List<BookInfo> list = bookManager.PagingFindBookInfo(content, index, size);
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        [HttpGet]
        public ActionResult DelBook(string ID)
        {
            bool result = bookManager.DeleteBookInfo(ID);
            if (!result)
                TempData["mess"] = "删除图书操作失败！";
            return Redirect("Index");
        }
        public ActionResult delUploadImg(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string runPath = "~/Images/book/";
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
                Session["bookImgPath"] = runPath.Substring(1, runPath.Length - 1) + fileName;
                file.SaveAs(userImg + fileName);//保存上传的图片
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBook(string name, string author, DateTime publishDate, string type, decimal price, decimal original, string describe)
        {
            string imgSrc = String.Empty;
            if (Session["bookImgPath"] != null && Session["bookImgPath"].ToString() != "")
                imgSrc = (string)Session["bookImgPath"];
            BookInfo bi = new BookInfo()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Author = author,
                PublishDate = publishDate,
                Price = price,
                Original = original,
                Describe = describe,
                ISBN = imgSrc,
                Type = type,
                Sale = 0,
                Stock = 0,
                CreateDate = DateTime.Now
            };
            Session["bookImgPath"] = null;
            bool success = bookManager.InsertBookInfo(bi); 
            if (success)
                TempData["mess"] = "成功添加新图书：" + bi.Name;
            return Redirect("Index");
        }
        public ActionResult EditBook(string ID)
        {
            BookInfo bi = bookManager.FindById(ID);
            return View(bi);
        }
        [HttpPost]
        public ActionResult EditBookInfo(string biId, string name, string author, DateTime publishDate, string type, decimal price, decimal original, string describe)
        {
            BookInfo bi = bookManager.FindById(biId);
            bi.Name = name;
            bi.Author = author;
            bi.PublishDate = publishDate;
            bi.Type = type;
            bi.Price = price;
            bi.Original = original;
            bi.Describe = describe;
            if (Session["bookImgPath"] != null && Session["bookImgPath"].ToString() != "")
            {
                bi.ISBN = (string)Session["bookImgPath"];
                Session["TypeImgPath"] = null;
            }
            bool result = bookManager.UpdateBookInfo(bi);
            if (result)
                TempData["mess"] = "图书‘" + bi.Name + "’修改成功";
            return Redirect("Index");
        }
        public ActionResult AddStock(string ID)
        {
            BookInfo bi = bookManager.FindById(ID);
            return View(bi);
        }
        [HttpPost]
        public ActionResult AddBookStock(string biId, string stockNum)
        {
            int num = Int32.Parse(string.IsNullOrEmpty(stockNum) ? "0" : stockNum);
            bool result = bookManager.UpdateBookInfoStock(biId, num);
            if (result)
            {
                BookInfo bi = bookManager.FindById(biId);
                TempData["mess"] = "成功记录图书‘" + bi.Name + "’进货" + num + "本";
            }
            return Redirect("Index");
        }
        [AllowAnonymous]
        public ActionResult FindBySearchText(string content)
        {
            Session["searchText_b"] = content;
            return Redirect("Index");
        }
    }
}
