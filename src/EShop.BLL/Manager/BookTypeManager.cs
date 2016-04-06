using EShop.DAL;
using EShop.DAL.Service;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.BLL.Manager
{
    public class BookTypeManager : IBookTypeManager
    {
        private IBookTypeServicecs _bookTypeService = new BookTypeServicecs();
        public List<BookType> FindBookType()
        {
            return _bookTypeService.FindBookType();
        }
        public List<BookType> PagingFindBookType(string name, int pageIndex, int PageSize) 
        {
            return _bookTypeService.PagingFindBookType(name, pageIndex, PageSize);
        }
        public int GetCount(string name)
        {
            return _bookTypeService.GetCount(name);
        }
        public bool InsertBookType(BookType bookType) 
        {
            return _bookTypeService.InsertBookType(bookType);
        }
        public bool DeleteBookType(string id) 
        {
            return _bookTypeService.DeleteBookType(id);
        }
        public bool UpdateBookType(BookType bookType) 
        {
            return _bookTypeService.UpdateBookType(bookType);
        }
        public BookType FindById(string id)
        {
            return _bookTypeService.FindById(id);
        }
    }
}
