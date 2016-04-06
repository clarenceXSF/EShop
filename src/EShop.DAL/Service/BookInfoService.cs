using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class BookInfoService : IBookInfoService
    {
        public List<BookInfo> PagingFindBookInfo(string search, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from b in db.BookInfo
                          where b.Name.Contains(search) || b.Author.Contains(search)
                          orderby b.CreateDate, b.PublishDate
                          select b;
                List<BookInfo> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string search)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from b in db.BookInfo
                           where b.Name.Contains(search) || b.Author.Contains(search)
                           select b).Count();
                return count;
            }
        }
        
        public bool InsertBookInfo(BookInfo bookInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                db.BookInfo.Add(bookInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteBookInfo(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                BookInfo bookInfo = new BookInfo() { Id = id };
                db.BookInfo.Attach(bookInfo);
                db.BookInfo.Remove(bookInfo);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateBookInfo(BookInfo bookInfo)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldBookInfo = db.BookInfo.Find(bookInfo.Id);
                if (oldBookInfo != null)
                {
                    oldBookInfo.Name = bookInfo.Name;
                    oldBookInfo.Author = bookInfo.Author;
                    oldBookInfo.Price = bookInfo.Price;
                    oldBookInfo.PublishDate = bookInfo.PublishDate;
                    oldBookInfo.Type = bookInfo.Type;
                    oldBookInfo.ISBN = bookInfo.ISBN;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }

        public bool UpdateBookInfoSale(string id, int num)
        {
            using (EShopDB db = new EShopDB())
            {
                var bookInfo = db.BookInfo.Find(id);
                bookInfo.Sale = bookInfo.Sale + num;
                return db.SaveChanges() > 0;
            }
        }

        public BookInfo FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from b in db.BookInfo 
                           where b.Id == id
                           select b).FirstOrDefault();
                return obj;
            }
        }
    }
}
