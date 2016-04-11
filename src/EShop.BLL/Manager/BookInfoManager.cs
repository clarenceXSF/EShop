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
        public List<BookInfo> PagingFindBookInfo(string search, int pageIndex, int pageSize)
        {
            return _bookInfoService.PagingFindBookInfo(search, pageIndex, pageSize);
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
            return _bookInfoService.FindById(id);
        }
        public List<BookInfo> FindByType(int type, int pageIndex, int pageSize)
        {
            return _bookInfoService.FindByType(type, pageIndex, pageSize);
        }
        public int GetCount(int type)
        {
            return _bookInfoService.GetCount(type);
        }
        public List<BookInfo> FindByType(int type, int size)
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
