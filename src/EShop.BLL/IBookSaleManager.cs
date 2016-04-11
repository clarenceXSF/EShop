using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL
{
    public interface IBookSaleManager
    {
        /// <summary>
        /// 根据关键字分页获取相关订单信息
        /// </summary>
        /// <param name="search">关键字(用户名/订单号)</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<BookSaleView> PagingFindBookSale(string search, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字的数量
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        int GetCount(string search);
        /// <summary>
        /// 添加订单信息(下单)
        /// </summary>
        /// <param name="bookSale"></param>
        /// <returns></returns>
        bool InsertBookSale(BookSale bookSale);
        /// <summary>
        /// 删除订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteBookSale(string id);
        /// <summary>
        /// 更新订单信息(发货)
        /// </summary>
        /// <param name="bookSale"></param>
        /// <returns></returns>
        bool UpdateBookSale(BookSale bookSale);
        /// <summary>
        /// 根据订单id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookSaleView FindById(string id);
        /// <summary>
        /// 根据用户id查询相关所有订单信息(前台界面--我的订单)
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        List<BookSaleView> FindByUserId(string uid);
        /// <summary>
        /// 统计用户订单次数(前台)
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        int GetBuyCount(string uid);
    }
}
