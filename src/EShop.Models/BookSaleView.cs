//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookSaleView
    {
        public string Id { get; set; }
        public string SaleNum { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public Nullable<int> GoodsNum { get; set; }
        public Nullable<decimal> CountPrice { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> State { get; set; }
        public string Address { get; set; }
        public string Evalute { get; set; }
    }
}
