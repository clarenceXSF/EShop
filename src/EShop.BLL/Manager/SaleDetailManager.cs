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
    public class SaleDetailManager : ISaleDetailManager
    {
        private ISaleDetailService _saleDetailService = new SaleDetailService();
        public List<SaleDetailView> FindSaleDetail(string BsId)
        {
            return _saleDetailService.FindSaleDetail(BsId);
        }
        public bool InsertSaleDetail(SaleDetail detail)
        {
            return _saleDetailService.InsertSaleDetail(detail);
        }
        public bool DeleteSaleDetail(string id)
        {
            return _saleDetailService.DeleteSaleDetail(id);
        }
    }
}
