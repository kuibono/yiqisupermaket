//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YiQiWorkFlow.Domain.Basement
{
    using System;
    using System.Collections.Generic;
    
    public partial class fb_adjust_supplier_goods
    {
        public string adjust_number { get; set; }
        public string goods_code { get; set; }
        public string sup_code_old { get; set; }
        public string op_code_old { get; set; }
        public string sup_code { get; set; }
        public string sup_name { get; set; }
        public string py_code { get; set; }
        public string op_code { get; set; }
        public Nullable<decimal> pool_rate { get; set; }
        public string offer_mode { get; set; }
        public Nullable<decimal> offer_min { get; set; }
        public Nullable<decimal> input_tax { get; set; }
        public Nullable<decimal> purchase_price { get; set; }
        public decimal nontax_purchase_price { get; set; }
        public string Id { get; set; }
    }
}
