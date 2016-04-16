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
    public class BookInfoManager : IBookInfoManager
    {
        private IBookInfoService _bookInfoService = new BookInfoService();
        private IBookTypeServicecs _typeService = new BookTypeServicecs();
        public List<BookInfo> PagingFindBookInfo(string search, int pageIndex, int pageSize)
        {
            List<BookInfo> list =  _bookInfoService.PagingFindBookInfo(search, pageIndex, pageSize);
            foreach (BookInfo bi in list)
            {
                BookType bt = _typeService.FindById(bi.Type);
                bi.Type = bt.TypeName;
            }
            return list;
        }
        public int GetCount(string search)
        {
            return _bookInfoService.GetCount(search);
        }
        public bool InsertBookInfo(BookInfo bookInfo)
        {
            return _bookInfoService.InsertBookInfo(bookInfo);
        }
        public bool DeleteBookInfo(string id)
        {
            return _bookInfoService.DeleteBookInfo(id);
        }
        public bool UpdateBookInfo(BookInfo bookInfo)
        {
            return _bookInfoService.UpdateBookInfo(bookInfo);
        }
        public bool UpdateBookInfoSale(string id, int num)
        {
            return _bookInfoService.UpdateBookInfoSale(id, num);
        }
        public bool UpdateBookInfoStock(string id, int num)
        {
            return _bookInfoService.UpdateBookInfoStock(id, num);
        }
        public BookInfo FindById(string id)
        {
            BookInfo bi = _bookInfoService.FindById(id);
            return bi;
        }
        public BookInfo FindByIdDelType(string id)
        {
            BookInfo bi =  _bookInfoService.FindById(id);
            BookType bt = _typeService.FindById(bi.Type);
            bi.Type = bt.TypeName;
            return bi;
        }
        public List<BookInfo> FindByType(string type, int pageIndex, int pageSize)
        {
            return _bookInfoService.FindByType(type, pageIndex, pageSize);
        }
        public int GetTypeCount(string type)
        {
            return _bookInfoService.GetTypeCount(type);
        }
        public List<BookInfo> FindByType(string type, int size)
        {
            return _bookInfoService.FindByType(type, size);
        }
        public List<BookInfo> FindTopCreate(int size)
        {
            return _bookInfoService.FindTopCreate(size);
        }
        public List<BookInfo> FindTopSale(int size)
        {
            return _bookInfoService.FindTopSale(size);
        }
        public List<string> FindAuthor(int size)
        {
            return _bookInfoService.FindAuthor(size);
        }
        public List<BookInfo> FindByAuthor(string author)
        {
            return _bookInfoService.FindByAuthor(author);
        }
    }
}
