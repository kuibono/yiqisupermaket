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
    
    public partial class tg_travel_balance
    {
        public string ba_number { get; set; }
        public Nullable<System.DateTime> ba_date { get; set; }
        public string en_code { get; set; }
        public string payway_code { get; set; }
        public string ta_code { get; set; }
        public string ta_name { get; set; }
        public Nullable<decimal> balance_money { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string @operator { get; set; }
        public string assessor { get; set; }
        public string if_examine { get; set; }
        public Nullable<System.DateTime> examine_date { get; set; }
        public Nullable<System.DateTime> operator_date { get; set; }
    }
}