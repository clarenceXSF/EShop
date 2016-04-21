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
    public class RecommendController : Controller
    {
        //
        // GET: /Recommend/
        private int rePageSize = 8;
        private IRecommendManager reManager = new RecommendManager();

        public ActionResult Index(int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? rePageSize;
            string content = String.Empty;
            if (Session["searchText_r"] != null && Session["searchText_r"].ToString() != "")
                content = (string)Session["searchText_r"];
            int count = reManager.GetCount(content);
            List<RecommendView> list = reManager.PagingFindRecommend(content, index, size);
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        [HttpGet]
        public ActionResult DelRecommend(string ID)
        {
            bool result = reManager.DeleteRecommend(ID);
            if (!result)
                TempData["mess"] = "删除推荐信息操作失败！";
            return Redirect("Index");
        }
        public ActionResult delUploadImg(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string runPath = "~/Images/recommend/";
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
                Session["RecommendImgPath"] = runPath.Substring(1, runPath.Length - 1) + fileName;
                file.SaveAs(userImg + fileName);//保存上传的图片
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
        public ActionResult AddRecommend()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewRecommend(string title, string book)
        {
            string imgSrc = String.Empty;
            if (Session["RecommendImgPath"] != null && Session["RecommendImgPath"].ToString() != "")
                imgSrc = (string)Session["RecommendImgPath"];
            Recommend re = new Recommend()
            {
                Id = Guid.NewGuid().ToString(),
                ShowTitle = title,
                ShowImage = imgSrc,
                BookId = book,
                CreateTime = DateTime.Now
            };
            Session["RecommendImgPath"] = null;
            bool success = reManager.InsertRecommend(re);
            if (success)
                TempData["mess"] = "成功添加新推荐信息：" + re.ShowTitle;
            return Redirect("Index");
        }
        public ActionResult EditRecommend(string ID)
        {
            RecommendView re = reManager.FindDetailById(ID);
            return View(re);
        }
        [HttpPost]
        public ActionResult EditRecommendInfo(string reId, string title)
        {
            Recommend re = reManager.FindById(reId);
            re.ShowTitle = title;
            if (Session["RecommendImgPath"] != null && Session["RecommendImgPath"].ToString() != "")
            {
                re.ShowImage = (string)Session["RecommendImgPath"];
                Session["RecommendImgPath"] = null;
            }
            bool result = reManager.UpdateRecommend(re);
            if (result)
                TempData["mess"] = "推荐信息‘" + re.ShowTitle + "’修改成功";
            return Redirect("Index");
        }
      
        [AllowAnonymous]
        public ActionResult FindBySearchText(string content)
        {
            Session["searchText_r"] = content;
            return Redirect("Index");
        }
    }
}
