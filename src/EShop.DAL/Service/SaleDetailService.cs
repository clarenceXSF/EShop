using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class SaleDetailService : ISaleDetailService
    {
        public List<SaleDetailView> FindSaleDetail(string BsId)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.SaleDetailView
                          where b.BsId == BsId 
                          select b;
                List<SaleDetailView> list = obj.ToList();
                return list;
            }
        }

        public bool InsertSaleDetail(SaleDetail detail)
        {
            using (EShopDB db = new EShopDB())
            {
                db.SaleDetail.Add(detail);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteSaleDetail(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                SaleDetail detail = new SaleDetail() { Id = id };
                db.SaleDetail.Attach(detail);
                db.SaleDetail.Remove(detail);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }
    }
}
