using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.BLL
{
    public interface IBookTypeManager
    {
        /// <summary>
        /// 显示所有图书类型
        /// </summary>
        /// <returns></returns>
        List<BookType> FindBookType();
        /// <summary>
        /// 根据类型名称或代码分页显示图书类型
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        List<BookType> PagingFindBookType(string name, int pageIndex, int PageSize);
        /// <summary>
        /// 统计名称或代码关键字的类型数量
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int GetCount(string name);
        /// <summary>
        /// 添加图书类型
        /// </summary>
        /// <param name="bookType"></param>
        /// <returns></returns>
        bool InsertBookType(BookType bookType);
        /// <summary>
        /// 删除图书类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteBookType(string id);
        /// <summary>
        /// 修改图书类型
        /// </summary>
        /// <param name="bookType"></param>
        /// <returns></returns>
        bool UpdateBookType(BookType bookType);
        /// <summary>
        /// 根据图书类型id获取图书类型信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookType FindById(string id);
        /// <summary>
        /// 根据类型名获取图书类型信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        BookType FindByName(string name);
    }
}
