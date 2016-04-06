using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.DAL
{
    public interface IBookTypeServicecs
    {
        List<BookType> FindBookType();
        int Count();
        List<BookType> PagingFindBookType(string name, int pageIndex, int PageSize);
        int GetCount(string name);
        bool InsertBookType(BookType BookType);
        bool DelectBookType(string id);
        bool UpdateBookType(BookType BookType);
        BookType FindById(string id);
    }
}
