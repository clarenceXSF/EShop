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
                          orderby b.CreateDate descending 
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
                if (bookInfo.Sale == null)
                    bookInfo.Sale = 0;
                bookInfo.Sale = bookInfo.Sale + num;
                bookInfo.Stock = bookInfo.Stock - num;
                return db.SaveChanges() > 0;
            }
        }

        public bool UpdateBookInfoStock(string id, int num)
        {
            using (EShopDB db = new EShopDB())
            {
                var bookInfo = db.BookInfo.Find(id);
                if (bookInfo.Stock == null)
                    bookInfo.Stock = 0;
                bookInfo.Stock = bookInfo.Stock + num;
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

        public List<BookInfo> FindByType(int type, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from b in db.BookInfo
                          where b.Type == type
                          orderby b.CreateDate descending 
                          select b;
                List<BookInfo> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(int type)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from b in db.BookInfo
                             where b.Type == type
                             select b).Count();
                return count;
            }
        }

        public List<BookInfo> FindByType(int type, int size)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.BookInfo
                          where b.Type == type
                          orderby b.PublishDate descending
                          select b;
                List<BookInfo> list = obj.Take(size).ToList();
                return list;
            }
        }

        public List<BookInfo> FindTopCreate(int size)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.BookInfo
                          orderby b.CreateDate descending
                          select b;
                List<BookInfo> list = obj.Take(size).ToList();
                return list;
            }
        }

        public List<BookInfo> FindTopSale(int size)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.BookInfo
                          orderby b.Sale descending
                          select b;
                List<BookInfo> list = obj.Take(size).ToList();
                return list;
            }
        }

        public List<string> FindAuthor(int size)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from b in db.BookInfo
                           orderby b.CreateDate descending 
                           select b.Author).Distinct();
                int count = obj.Count();
                if (count > size)
                    return obj.Take(size).ToList();
                else
                    return obj.ToList();
            }
        }

        public List<BookInfo> FindByAuthor(string author)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from b in db.BookInfo
                          where b.Author == author
                          orderby b.CreateDate descending
                          select b;
                List<BookInfo> list = obj.ToList();
                return list;
            }
        }
    }
}
