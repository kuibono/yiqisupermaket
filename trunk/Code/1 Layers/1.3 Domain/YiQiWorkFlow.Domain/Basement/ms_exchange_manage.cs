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
    
    public partial class ms_exchange_manage
    {
        public decimal ex_flow_number { get; set; }
        public string exchange_number { get; set; }
        public Nullable<System.DateTime> exchange_date { get; set; }
        public string card_number { get; set; }
        public string ms_code { get; set; }
        public string ms_name { get; set; }
        public Nullable<decimal> current_points { get; set; }
        public Nullable<decimal> exchange_points { get; set; }
        public Nullable<decimal> surplus_points { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> operator_date { get; set; }
    }
}
