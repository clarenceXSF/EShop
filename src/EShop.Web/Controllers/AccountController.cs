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
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private IUserInfoManager userManager = new UserInfoManager();
        /// <summary>
        /// 后台管理员登录入口
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(string loginId, string loginPwd)
        {
            UserInfo ui = userManager.FindByLoginId(loginId);
            if (ui == null)
                TempData["mess"] = "登录名不存在";
            else 
            {
                if (ui.LoginPwd != loginPwd)
                    TempData["mess"] = "登录名或密码错误";
                else if(ui.Role < 90)
                    TempData["mess"] = "暂无访问权限";
                else
                    return RedirectToAction("Index", "Integration");
            }
            return Redirect("Index");
        }

        /// <summary>
        /// 客户端登录注册入口
        /// </summary>
        /// <returns></returns>
        public ActionResult UserIndex()
        {
            return View();
        }
        // Ajax验证登录名是否唯一
        [AllowAnonymous]
        [HttpPost]
        public string CheckTheloginId(string loginId)
        {
            string result = "0";
            bool valid = userManager.CheckLoginId(loginId);
            if (valid) result = "1";//存在
            return result;
        }
        [HttpPost]
        public ActionResult CustomerLogin(string loginId, string loginPwd)
        {
            UserInfo ui = userManager.FindByLoginId(loginId);
            if (ui == null)
            {
                TempData["mess"] = "登录名不存在";
                return Redirect("UserIndex");
            }
            else
            {
                if (ui.LoginPwd != loginPwd)
                {
                    TempData["mess"] = "登录名或密码错误";
                    return Redirect("UserIndex");
                }
                else
                {
                    if (string.IsNullOrEmpty(ui.Name))
                        Session["loginName"] = ui.Name;
                    else
                        Session["loginName"] = loginId;
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        [HttpPost]
        public ActionResult CustomerRegister(string loginId, string loginPwd)
        {
            UserInfo ui = new UserInfo()
            {
                Id = Guid.NewGuid().ToString(),
                LoginId = loginId,
                LoginPwd = loginPwd,
                Role = 1,
                CreateTime = DateTime.Now
            };
            bool success = userManager.InsertUserInfo(ui);
            if (success)
            {
                TempData["mess"] = "恭喜您注册成功";
                Session["loginName"] = loginId;
            }else
                TempData["mess"] = "很抱歉，本次注册操作失败";
            return Redirect("UserIndex");
        }
    }
}
