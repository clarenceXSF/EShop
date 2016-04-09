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
        /// <summary>
        /// 根据关键字分页获取相关图书信息
        /// </summary>
        /// <param name="search">搜索关键字(书名/作者)</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageSize">显示数量</param>
        /// <returns></returns>
        List<BookInfo> PagingFindBookInfo(string search, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字的数量
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        int GetCount(string search);
        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        bool InsertBookInfo(BookInfo bookInfo);
        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteBookInfo(string id);
        /// <summary>
        /// 更新图书信息
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        bool UpdateBookInfo(BookInfo bookInfo);
        /// <summary>
        /// 更新图书销售量（出售）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        bool UpdateBookInfoSale(string id, int num);
        /// <summary>
        /// 更新图书库存量（进货）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        bool UpdateBookInfoStock(string id, int num);
        /// <summary>
        /// 根据图书id获取图书信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookInfo FindById(string id);
        /// <summary>
        /// 根据图书类型分页获取相关图书信息(后台)
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<BookInfo> FindByType(int type, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应图书类型的数量
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        int GetCount(int type);
        /// <summary>
        /// 根据图书类型获取指定数量的图书信息(前台界面显示)
        /// </summary>
        /// <param name="type"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        List<BookInfo> FindByType(int type, int size);
        /// <summary>
        /// 根据上架时间获取图书信息(前台界面显示)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        List<BookInfo> FindTopCreate(int size);
        /// <summary>
        /// 根据销售量获取图书信息(前台界面显示)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        List<BookInfo> FindTopSale(int size);
        /// <summary>
        /// 查询指定数量的作者(前台界面显示)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        List<string> FindAuthor(int size);
        /// <summary>
        /// 根据作者查询相关图书信息(前台界面显示)
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        List<BookInfo> FindByAuthor(string author);
    }
}
