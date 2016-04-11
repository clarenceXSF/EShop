using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class UserInfoService : IUserInfoService
    {
        public List<UserInfo> PagingFindUserInfo(string search, int role, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from u in db.UserInfo
                          where (u.Name.Contains(search) || u.LoginId.Contains(search )) && u.Role == role
                          orderby u.CreateTime descending
                          select u;
                List<UserInfo> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string search, int role)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from u in db.UserInfo
                             where (u.Name.Contains(search) || u.LoginId.Contains(search)) && u.Role == role
                             select u).Count();
                return count;
            }
        }

        public bool InsertUserInfo(UserInfo userInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                db.UserInfo.Add(userInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteUserInfo(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                UserInfo userInfo = new UserInfo() { Id = id };
                db.UserInfo.Attach(userInfo);
                db.UserInfo.Remove(userInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateUserInfo(UserInfo userInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldUserInfo = db.UserInfo.Find(userInfo.Id);
                if (oldUserInfo != null)
                {
                    oldUserInfo.Name = userInfo.Name;
                    oldUserInfo.Phone = userInfo.Phone;
                    oldUserInfo.Email = userInfo.Email;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }

        public bool UpdateUserState(UserInfo userInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldUserInfo = db.UserInfo.Find(userInfo.Id);
                oldUserInfo.State = userInfo.State;
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateUserScore(UserInfo userInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldUserInfo = db.UserInfo.Find(userInfo.Id);
                oldUserInfo.Score = userInfo.Score;
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateUserRole(UserInfo userInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldUserInfo = db.UserInfo.Find(userInfo.Id);
                oldUserInfo.Role = userInfo.Role;
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public UserInfo FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from u in db.UserInfo
                           where u.Id == id
                           select u).FirstOrDefault();
                return obj;
            }
        }

        public UserInfo FindByLogin(string loginContext)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from u in db.UserInfo
                           where u.LoginId == loginContext || u.Phone == loginContext
                           select u).FirstOrDefault();
                return obj;
            }
        }
    }
}
