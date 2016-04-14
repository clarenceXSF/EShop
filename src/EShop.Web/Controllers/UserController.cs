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
    public class UserController : Controller
    {
        //
        // GET: /User/
        private int uiPageSize = 8;
        private IUserInfoManager uiManager = new UserInfoManager();
        public ActionResult Index(int? pageIndex, int? pageSize)
        {
            int index = pageIndex ?? 1;
            int size = pageSize ?? uiPageSize;
            string content = String.Empty;
            if (Session["searchText"] != null && Session["searchText"].ToString() != "")
                content = (string)Session["searchText"];
            List<UserInfo> list = null;
            int count = 0;
            if (Session["showRole"].ToString().Equals("admin"))
            {
                list = uiManager.PagingFindAdminInfo(content, 90, index, size);
                count = uiManager.GetAdminCount(content, 90);
                if (count < 1) TempData["mess"] = "暂无相关管理员信息！";
            }
            else 
            {
                list = uiManager.PagingFindUserInfo(content, 90, index, size);
                count = uiManager.GetCount(content, 90);
                if (count < 1) TempData["mess"] = "暂无相关客户信息！";
            }
            Pager page = new Pager(index, size, count);
            ViewData["page"] = page;
            return View(list);
        }
        public ActionResult Show(string role)
        {
            Session["showRole"] = role;
            return Redirect("Index");
        }
        [HttpGet]
        public ActionResult DelUser(string ID)
        {
            bool result = uiManager.DeleteUserInfo(ID);
            if (!result)
                TempData["mess"] = "删除人员信息操作失败！";
            return Redirect("Index");
        }

        public ActionResult AddUser()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult AddNewUser(string loginId, string loginPwd,string name,string phone,string email)
        {
            UserInfo ui = new UserInfo()
            {
                Id = Guid.NewGuid().ToString(),
                LoginId = loginId,
                LoginPwd = loginPwd,
                Name = name,
                Phone = phone,
                Email = email,
                Role = 98,
                CreateTime = DateTime.Now
            };
            bool success = uiManager.InsertUserInfo(ui);
            if (success)
                TempData["mess"] = "成功添加新管理员：" + ui.Name;
            return Redirect("Index");
        }

        /// <summary>
        /// 修改图书类型页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult EditUser(string ID)
        {
            UserInfo ui = uiManager.FindById(ID);
            return View(ui);
        }
        [HttpPost]
        public ActionResult EditUserInfo(string Id, string loginId, string loginPwd, string name, string phone, string email)
        {
            UserInfo ui = uiManager.FindById(Id);
            ui.LoginId = loginId;
            ui.LoginPwd = loginPwd;
            ui.Name = name;
            ui.Phone = phone;
            ui.Email = email;
            bool result = uiManager.UpdateUserInfo(ui);
            if (result)
                TempData["mess"] = "修改管理员‘" + ui.Name + "’信息成功";
            return Redirect("Index");
        }
        [AllowAnonymous]
        public ActionResult FindBySearchText(string content)
        {
            Session["searchText"] = content;
            return Redirect("Index");
        }
        // Ajax验证登录名是否唯一
        [AllowAnonymous]
        [HttpPost]
        public string CheckTheloginId(string loginId)
        {
            string result="0";
            bool valid = uiManager.FindByLoginId(loginId);
            if (valid) result = "1";//存在
            return result;
        }
    }
}
