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
    public class OtherTypeManager : IOtherTypeManager
    {
        private IOtherTypeService _otherTypeService = new OtherTypeService();
        public List<OtherType> PagingFindOtherType(string name, string content, int pageIndex, int pageSize)
        {
            return _otherTypeService.PagingFindOtherType(name, content, pageIndex, pageSize);
        }
        public int GetCount(string name, string content)
        {
            return _otherTypeService.GetCount(name, content);
        }
        public bool InsertOtherType(OtherType otherType)
        {
            return _otherTypeService.InsertOtherType(otherType);
        }
        public bool DeleteOtherType(string id)
        {
            return _otherTypeService.DeleteOtherType(id);
        }
        public bool UpdateOtherType(OtherType otherType)
        {
            return _otherTypeService.UpdateOtherType(otherType);
        }
        public OtherType FindById(string id)
        {
            return _otherTypeService.FindById(id);
        }
    }
}
