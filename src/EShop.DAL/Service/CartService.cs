using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class CartService : ICartService
    {
        public List<CartView> PagingFindCartInfo(string uid, int pageIndex, int pageSize) 
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from c in db.CartView
                          where c.UserId == uid 
                          orderby c.CreateTime descending
                          select c;
                List<CartView> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }
        public int GetCount(string uid)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from c in db.CartView
                             where c.UserId == uid 
                             select c).Count();
                return count;
            }
        }
        public bool InsertCartInfo(ShoppingCart cInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                db.ShoppingCart.Add(cInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }
        public bool DeleteCartInfo(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                ShoppingCart cInfo = new ShoppingCart() { Id = id };
                db.ShoppingCart.Attach(cInfo);
                db.ShoppingCart.Remove(cInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }
    }
}
