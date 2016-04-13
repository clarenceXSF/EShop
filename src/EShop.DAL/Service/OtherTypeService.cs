using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Service
{
    public class OtherTypeService : IOtherTypeService
    {
        public List<OtherType> PagingFindOtherType(string name, string content, int pageIndex, int pageSize)
        {
            using (EShopDB db = new EShopDB())
            {
                if (pageIndex == 0)
                    pageIndex = 1;
                var obj = from ot in db.OtherType
                          where ot.TypeName == name && ot.TypeContent.Contains(content)
                          orderby ot.TypeCode
                          select ot;
                List<OtherType> list = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                return list;
            }
        }

        public int GetCount(string name, string content)
        {
            using (EShopDB db = new EShopDB())
            {
                if (String.IsNullOrEmpty(name))
                    name = String.Empty;
                if (String.IsNullOrEmpty(content))
                    content = String.Empty;
                int count = (from ot in db.OtherType
                             where ot.TypeName == name && ot.TypeContent.Contains(content)
                             select ot).Count();
                return count;
            }
        }

        public bool InsertOtherType(OtherType otherType)
        {
            using (EShopDB db = new EShopDB())
            {
                db.OtherType.Add(otherType);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool DeleteOtherType(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                OtherType otherType = new OtherType() { Id = id };
                db.OtherType.Attach(otherType);
                db.OtherType.Remove(otherType);
                bool isSuccess = db.SaveChanges() > 0;
                return isSuccess;
            }
        }

        public bool UpdateOtherType(OtherType otherType)
        {
            using (EShopDB db = new EShopDB())
            {
                var oldOtherType = db.OtherType.Find(otherType.Id);
                if (oldOtherType != null)
                {
                    oldOtherType.TypeCode = otherType.TypeCode;
                    oldOtherType.TypeContent = otherType.TypeContent;
                    bool isSuccess = db.SaveChanges() > 0;
                    return isSuccess;
                }
                else
                    return false;
            }
        }

        public OtherType FindById(string id)
        {
            using (EShopDB db = new EShopDB())
            {
                var obj = (from ot in db.OtherType
                           where ot.Id == id
                           select ot).FirstOrDefault();
                return obj;
            }
        }
    }
}
