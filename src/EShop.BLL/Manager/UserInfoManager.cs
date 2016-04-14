using EShop.DAL;
using EShop.DAL.Service;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.Manager
{
    public class UserInfoManager : IUserInfoManager
    {
        private IUserInfoService _userInfoService = new UserInfoService();
        public List<UserInfo> PagingFindUserInfo(string search, int role, int pageIndex, int pageSize)
        {
            return _userInfoService.PagingFindUserInfo(search, role, pageIndex, pageSize);
        }
        public int GetCount(string search, int role)
        {
            return _userInfoService.GetCount(search, role);
        }
        public List<UserInfo> PagingFindAdminInfo(string search, int role, int pageIndex, int pageSize)
        {
            return _userInfoService.PagingFindAdminInfo(search, role, pageIndex, pageSize);
        }
        public int GetAdminCount(string search, int role)
        {
            return _userInfoService.GetAdminCount(search, role);
        }
        public bool InsertUserInfo(UserInfo userInfo)
        {
            return _userInfoService.InsertUserInfo(userInfo);
        }
        public bool DeleteUserInfo(string id)
        {
            return _userInfoService.DeleteUserInfo(id);
        }
        public bool UpdateUserInfo(UserInfo userInfo)
        {
            return _userInfoService.UpdateUserInfo(userInfo);
        }
        public bool UpdateUserState(UserInfo userInfo)
        {
            return _userInfoService.UpdateUserState(userInfo);
        }
        public bool UpdateUserScore(UserInfo userInfo)
        {
            return _userInfoService.UpdateUserScore(userInfo);
        }
        public bool UpdateUserRole(UserInfo userInfo)
        {
            return _userInfoService.UpdateUserRole(userInfo);
        }
        public UserInfo FindById(string id)
        {
            return _userInfoService.FindById(id);
        }
        public UserInfo FindByLogin(string loginContext)
        {
            return _userInfoService.FindByLogin(loginContext);
        }
        public bool CheckLoginId(string loginId)
        {
            UserInfo ui = _userInfoService.FindByLoginId(loginId);
            if (ui != null)
                return true;
            else
                return false;
        }
        public UserInfo FindByLoginId(string loginId)
        {
            return _userInfoService.FindByLoginId(loginId);
        }
    }
}
