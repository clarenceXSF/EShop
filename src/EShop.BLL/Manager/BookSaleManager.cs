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
    public interface BookSaleManager : IBookSaleManager
    {
        private IBookSaleService _bookSaleService = new BookSaleService();
       // private ISaleDetailService _saleDetailService = new SaleDetailService();
        public List<BookSaleView> PagingFindBookInfo(string search, int pageIndex, int pageSize)
        {
            return _bookSaleService.PagingFindBookSale(search, pageIndex, pageSize);
        }
        public int GetCount(string search)
        {
            return _bookSaleService.GetCount(search);
        }
        public bool InsertBookSale(BookSale bookSale)
        {
            return _bookSaleService.InsertBookSale(bookSale);
        }
        public bool DeleteBookSale(string id)
        {
            return _bookSaleService.DeleteBookSale(id);
        }
        public bool UpdateBookSale(BookSale bookSale)
        {
            return _bookSaleService.UpdateBookSale(bookSale);
        }
        public BookSaleView FindById(string id)
        {
            return _bookSaleService.FindById(id);
        }
        public List<BookSaleView> FindByUserId(string uid)
        {
            return _bookSaleService.FindByUserId(uid);
        }
        public int GetBuyCount(string uid)
        {
            return _bookSaleService.GetBuyCount(uid);
        }
    }
}
