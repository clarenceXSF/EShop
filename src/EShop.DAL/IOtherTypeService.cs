using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL
{
    public interface IOtherTypeService
    {
        /// <summary>
        /// 根据关键字分页获取相关类型信息
        /// </summary>
        /// <param name="name">类名</param>
        /// <param name="content">内容</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<OtherType> PagingFindOtherType(string name, string content, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字的数量
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        int GetCount(string name, string content);
        /// <summary>
        /// 添加类型信息
        /// </summary>
        /// <param name="otherType"></param>
        /// <returns></returns>
        bool InsertOtherType(OtherType otherType);
        /// <summary>
        /// 删除类型信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteOtherType(string id);
        /// <summary>
        /// 修改类型信息
        /// </summary>
        /// <param name="otherType"></param>
        /// <returns></returns>
        bool UpdateOtherType(OtherType otherType);
        /// <summary>
        /// 根据类型id获取类型信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OtherType FindById(string id);
    }
}
