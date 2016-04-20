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
    public class RecommendManager : IRecommendManager
    {
        private IRecommendService _recommendService = new RecommendService();
        public List<RecommendView> PagingFindRecommend(string search, int pageIndex, int pageSize)
        {
            return _recommendService.PagingFindRecommend(search, pageIndex, pageSize);
        }
        public int GetCount(string search)
        {
            return _recommendService.GetCount(search);
        }
        public bool InsertRecommend(Recommend recommend)
        {
            return _recommendService.InsertRecommend(recommend);
        }
        public bool DeleteRecommend(string id)
        {
            return _recommendService.DeleteRecommend(id);
        }
        public bool UpdateRecommend(Recommend recommend)
        {
            return _recommendService.UpdateRecommend(recommend);
        }
        public Recommend FindById(string id)
        {
            return _recommendService.FindById(id);
        }
        public RecommendView FindDetailById(string id)
        {
            return _recommendService.FindDetailById(id);
        }
    }
}
