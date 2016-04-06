using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.BLL
{
    public interface IBookTypeManager
    {
        List<BookType> FindBookType();
        List<BookType> PagingFindBookType(string name, int pageIndex, int PageSize);
        int GetCount(string name);
        bool InsertBookType(BookType bookType);
        bool DeleteBookType(string id);
        bool UpdateBookType(BookType bookType);
        BookType FindById(string id);
    }
}
