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
    
    public partial class ms_card_archives
    {
        public string card_number { get; set; }
        public string surface_number { get; set; }
        public string ms_code { get; set; }
        public string card_code { get; set; }
        public string card_name { get; set; }
        public string ms_name { get; set; }
        public string card_state { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> grant_date { get; set; }
        public Nullable<System.DateTime> effective_date { get; set; }
        public Nullable<System.DateTime> points_useful_life_date { get; set; }
        public Nullable<System.DateTime> card_useful_life_date { get; set; }
        public Nullable<decimal> transact_charge { get; set; }
        public Nullable<decimal> deposit_money { get; set; }
        public Nullable<decimal> total_money { get; set; }
        public Nullable<decimal> total_expend_times { get; set; }
        public Nullable<decimal> last_expend_money { get; set; }
        public Nullable<decimal> total_points { get; set; }
        public Nullable<decimal> exchange_points { get; set; }
        public Nullable<decimal> current_points { get; set; }
        public Nullable<decimal> clear_points { get; set; }
        public string prepaid_password { get; set; }
        public Nullable<decimal> total_prepaid { get; set; }
        public Nullable<decimal> current_prepaid { get; set; }
        public string current_prepaid_encrypt { get; set; }
        public Nullable<decimal> use_prepaid { get; set; }
        public Nullable<decimal> limit_times { get; set; }
        public Nullable<decimal> sale_times { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> operator_date { get; set; }
    }
}