using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL
{
    public interface ISaleDetailManager
    {
        /// <summary>
        /// 根据订单id查询订单详细
        /// </summary>
        /// <param name="BsId"></param>
        /// <returns></returns>
        List<SaleDetailView> FindSaleDetail(string BsId);
        /// <summary>
        /// 添加订单详细
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        bool InsertSaleDetail(SaleDetail detail);
        /// <summary>
        /// 删除订单详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteSaleDetail(string id);
    }
}
