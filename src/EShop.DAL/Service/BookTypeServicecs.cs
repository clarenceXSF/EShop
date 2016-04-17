using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.DAL.Service
{
    public class BookTypeServicecs : IBookTypeServicecs
    {
        public List<BookType> FindBookType()
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = from bt in db.BookType
                          orderby bt.TypeCode
                          select bt;
                return obj.ToList();
            }
        }

        public int Count()
        {
            using (EShopDB db = new EShopDB())
            {
                int count = db.BookType.Count();
                return count;
            }
        }

        public List<BookType> PagingFindBookType(string name, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from bt in db.BookType
                          where bt.TypeName.Contains(name) || bt.TypeCode.Contains(name)
                          orderby bt.TypeCode
                          select bt;
                List<BookType> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string name)
        {
            using (EShopDB db = new EShopDB())
            {
                if (String.IsNullOrEmpty(name))
                    name = String.Empty;
                int count = (from bt in db.BookType
                             where bt.TypeName.Contains(name) || bt.TypeCode.Contains(name)
                             select bt).Count();
                return count;
            }
        }

        public bool InsertBookType(BookType bookType)
        {
            using (EShopDB db = new EShopDB())
            {
                db.BookType.Add(bookType);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteBookType(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                BookType BookType = new BookType() { Id = id };
                db.BookType.Attach(BookType);
                db.BookType.Remove(BookType);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateBookType(BookType bookType)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldBookType = db.BookType.Find(bookType.Id);
                if (oldBookType != null)
                {
                    oldBookType.TypeCode = bookType.TypeCode;
                    oldBookType.TypeName = bookType.TypeName;
                    oldBookType.ImgSrc = bookType.ImgSrc;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }
        public BookType FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from bt in db.BookType
                           where bt.Id == id
                           select bt).FirstOrDefault();
                return obj;
            }
        }
        public BookType FindByName(string name)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from bt in db.BookType
                           where bt.TypeName.Contains(name)
                           select bt).FirstOrDefault();
                return obj;
            }
        }
    }
}
