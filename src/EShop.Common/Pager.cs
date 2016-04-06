using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop.Common
{
    public class Pager
    {
        private int _pageIndex;
        private int _pageSize;
        private int _total ;
        private int _pageCount;
        private int _start;
        private int _end;
        private bool _hasPrev;
        private bool _hasNext;
        private string _remark;
        /// <summary>
        /// ��ǰҳ
        /// </summary>
        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                if (value < 1)
                {
                    _pageIndex = 1;
                }
                else if (value > PageCount)
                {
                    _pageIndex = PageCount;
                }
                else
                {
                    _pageIndex = value;
                }
            }
        }
        /// <summary>
        /// ÿҳ��¼��
        /// </summary>
        public int PageSize {
            get
            {
                return _pageSize;
            }
            set
            {
                if (value < 1)
                {
                    _pageSize = 1;
                }
                else
                {
                    _pageSize = value;
                }
            }
        }
        /// <summary>
        /// ��ҳ��
        /// </summary>
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
        }
        /// <summary>
        /// �ܼ�¼��
        /// </summary>
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value < 0)
                {
                    _total = 0;
                }
                else
                {
                    _total = value;
                }
            }
        }
        /// <summary>
        /// ��ʼҳ��
        /// </summary>
        public int Start
        {
            get
            {
                return _start;
            }
        }
        /// <summary>
        /// ����ҳ��
        /// </summary>
        public int End
        {
            get
            {
                return _end;
            }
        }
        /// <summary>
        /// �Ƿ�����һҳ
        /// </summary>
        public bool HasPrev
        {
            get
            {
                return _hasPrev;
            }
        }
        /// <summary>
        /// �Ƿ�����һҳ
        /// </summary>
        public bool HasNext
        {
            get
            {
                return _hasNext;
            }
        }
        /// <summary>
        /// ��ע��Ϣ
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        /// <summary>
        /// Ψһ�Ĺ��캯��
        /// </summary>
        /// <param name="pageIndex">��ǰҳ</param>
        /// <param name="pageSize">ҳ��ʾ��¼��</param>
        /// <param name="total">�ܼ�¼��</param>
        public Pager(int pageIndex,int pageSize,int total) {
            this.PageSize = pageSize;
            this.Total = total;
            _pageCount=_total % _pageSize == 0 ? _total / _pageSize : (_total / _pageSize) + 1;
            if (_pageCount == 0) _pageCount = 1;//��ҳ������Ϊ0����СҲΪ1
            PageIndex = pageIndex;
            _start = _pageIndex - 3 > 1 ? _pageIndex - 3 : 1;
            _end = _pageIndex + 3 < PageCount ? _pageIndex + 3 : PageCount;
            _hasPrev = _pageIndex > 1;
            _hasNext = _pageIndex < PageCount;
        }
    }
}
