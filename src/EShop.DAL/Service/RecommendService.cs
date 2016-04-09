using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class RecommendService : IRecommendService
    {
        public List<RecommendView> PagingFindRecommend(string search, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from r in db.RecommendView
                          where r.BookName.Contains(search) || r.ShowTitle.Contains(search)
                          orderby r.CreateTime descending
                          select r;
                List<RecommendView> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string search)
        {
            using (EShopDB db = new EShopDB())
            {
                int count = (from r in db.RecommendView
                             where r.BookName.Contains(search) || r.ShowTitle.Contains(search)
                             select r).Count();
                return count;
            }
        }

        public bool InsertRecommend(Recommend recommend)
        {
            using (EShopDB db = new EShopDB())
            {
                db.Recommend.Add(recommend);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteRecommend(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                Recommend recommend = new Recommend() { Id = id };
                db.Recommend.Attach(recommend);
                db.Recommend.Remove(recommend);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateRecommend(Recommend recommend)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldRecommend = db.Recommend.Find(recommend.Id);
                if (oldRecommend != null)
                {
                    oldRecommend.BookId = recommend.BookId;
                    oldRecommend.ShowImage = recommend.ShowImage;
                    oldRecommend.ShowTitle = recommend.ShowTitle;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }

        public Recommend FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from r in db.Recommend
                           where r.Id == id
                           select r).FirstOrDefault();
                return obj;
            }
        }
    }
}
