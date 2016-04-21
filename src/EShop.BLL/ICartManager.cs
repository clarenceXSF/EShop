using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL
{
    public interface ICartManager
    {
        /// <summary>
        /// 根据用户id获取购物车信息
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<CartView> PagingFindCartInfo(string uid, int pageIndex, int pageSize);
        /// <summary>
        /// 统计用户购物车数量
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        int GetCount(string uid);
        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        bool InsertCartInfo(ShoppingCart cInfo);
        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteCartInfo(string id);
    }
}
