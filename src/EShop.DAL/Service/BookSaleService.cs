using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class BookSaleService : IBookSaleService
    {
        public List<BookSaleView> PagingFindBookInfo(string search, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from b in db.BookSaleView
                          where b.UserName.Contains(search) || b.SaleNum.Contains(search)
                          orderby b.CreateTime descending
                          select b;
                List<BookSaleView> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string search)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from b in db.BookSaleView
                             where b.UserName.Contains(search) || b.SaleNum.Contains(search)
                             select b).Count();
                return count;
            }
        }

        public bool InsertBookSale(BookSale bookSale)
        {
            using (EShopDB db = new EShopDB())
            {
                db.BookSale.Add(bookSale);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteBookSale(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                BookSale bookSale = new BookSale() { Id = id };
                db.BookSale.Attach(bookSale);
                db.BookSale.Remove(bookSale);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateBookSale(BookSale bookSale)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldBookSale = db.BookSale.Find(bookSale.Id);
                if (oldBookSale != null)
                {
                    oldBookSale.UpdateBy = bookSale.UpdateBy;
                    oldBookSale.UpdateTime = DateTime.Now;
                    oldBookSale.State = bookSale.State;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }

        public BookSaleView FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from b in db.BookSaleView
                           where b.Id == id
                           select b).FirstOrDefault();
                return obj;
            }
        }

        public List<BookSaleView> FindByUserId(string uid)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.BookSaleView
                          where b.UserId == uid
                          orderby b.CreateTime descending
                          select b;
                List<BookSaleView> list = obj.ToList();
                return list;
            }
        }

        public int GetBuyCount(string uid)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from b in db.BookSaleView
                             where b.UserId == uid
                             select b).Count();
                return count;
            }
        }
    }
}
