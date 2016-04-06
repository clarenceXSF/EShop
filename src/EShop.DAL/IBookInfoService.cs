using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL
{
    public interface IBookInfoService
    {
        List<BookInfo> PagingFindBookInfo(string search, int pageIndex, int pageSize);
        int GetCount(string search);
        bool InsertBookInfo(BookInfo bookInfo);
        bool DeleteBookInfo(string id);
        bool UpdateBookInfo(BookInfo bookInfo);
        bool UpdateBookInfoSale(string id, int num);
        BookInfo FindById(string id);
    }
}
