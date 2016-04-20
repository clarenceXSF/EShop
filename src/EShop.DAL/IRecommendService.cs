using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL
{
    public interface IRecommendService
    {
        /// <summary>
        /// 根据关键字分页获取相关推荐信息
        /// </summary>
        /// <param name="search"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<RecommendView> PagingFindRecommend(string search, int pageIndex, int pageSize);
        /// <summary>
        /// 统计对应关键字的数量
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        int GetCount(string search);
        /// <summary>
        /// 添加推荐信息
        /// </summary>
        /// <param name="recommend"></param>
        /// <returns></returns>
        bool InsertRecommend(Recommend recommend);
        /// <summary>
        /// 删除推荐信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteRecommend(string id);
        /// <summary>
        /// 修改推荐信息
        /// </summary>
        /// <param name="recommend"></param>
        /// <returns></returns>
        bool UpdateRecommend(Recommend recommend);
        /// <summary>
        /// 根据id获取推荐信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Recommend FindById(string id);
        /// <summary>
        /// 根据id获取推荐详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        RecommendView FindDetailById(string id);
    }
}
