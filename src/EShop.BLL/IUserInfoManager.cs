using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL
{
    public interface IUserInfoManager
    {
        /// <summary>
        /// 根据关键字和角色分页获取相关人员信息
        /// </summary>
        /// <param name="search">关键字</param>
        /// <param name="role">角色</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<UserInfo> PagingFindUserInfo(string search, int role, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字和角色的数量
        /// </summary>
        /// <param name="search"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        int GetCount(string search, int role);
        /// <summary>
        /// 根据关键字和角色分页获取相关人员信息(管理)
        /// </summary>
        /// <param name="search">关键字</param>
        /// <param name="role">角色</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<UserInfo> PagingFindAdminInfo(string search, int role, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字和角色的数量(管理)
        /// </summary>
        /// <param name="search"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        int GetAdminCount(string search, int role);
        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        bool InsertUserInfo(UserInfo userInfo);
        /// <summary>
        /// 删除人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteUserInfo(string id);
        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        bool UpdateUserInfo(UserInfo userInfo);
        /// <summary>
        /// 修改人员状态
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        bool UpdateUserState(UserInfo userInfo);
        /// <summary>
        /// 修改用户积分(前台)
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        bool UpdateUserScore(UserInfo userInfo);
        /// <summary>
        /// 修改管理员角色(后台)
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        bool UpdateUserRole(UserInfo userInfo);
        /// <summary>
        /// 根据id获取人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserInfo FindById(string id);
        /// <summary>
        /// 根据登录账号获取人员信息
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        UserInfo FindByLogin(string loginContext);
        /// <summary>
        /// 验证登录名是否已存在
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        bool CheckLoginId(string loginId);
        /// <summary>
        /// 根据登录名获取人员信息
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        UserInfo FindByLoginId(string loginId);
    }
}
