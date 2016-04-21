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
    public class CartManager : ICartManager
    {
        private ICartService cartService = new CartService();
        public List<CartView> PagingFindCartInfo(string uid, int pageIndex, int pageSize)
        {
            return cartService.PagingFindCartInfo(uid, pageIndex, pageSize);
        }
        public int GetCount(string uid)
        {
            return cartService.GetCount(uid);
        }
        public bool InsertCartInfo(ShoppingCart cInfo)
        {
            return cartService.InsertCartInfo(cInfo);
        }
        public bool DeleteCartInfo(string id)
        {
            return cartService.DeleteCartInfo(id);
        }
    }
}
