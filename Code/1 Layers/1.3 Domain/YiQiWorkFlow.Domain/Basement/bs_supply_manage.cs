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
    
    public partial class bs_supply_manage
    {
        public string sp_number { get; set; }
        public string b_code { get; set; }
        public string en_code { get; set; }
        public string wh_code { get; set; }
        public string wh_code_out { get; set; }
        public string sp_type { get; set; }
        public string sp_state { get; set; }
        public Nullable<System.DateTime> purchase_date { get; set; }
        public Nullable<System.DateTime> expect_arrive_date { get; set; }
        public Nullable<System.DateTime> supply_date { get; set; }
        public Nullable<System.DateTime> putin_date { get; set; }
        public Nullable<decimal> supply_money { get; set; }
        public string if_balance { get; set; }
        public string ba_number { get; set; }
        public Nullable<decimal> ba_money { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string @operator { get; set; }
        public string purchase_assessor { get; set; }
        public string purchase_if_examine { get; set; }
        public Nullable<System.DateTime> purchase_examine_date { get; set; }
        public string supply_assessor { get; set; }
        public string supply_if_examine { get; set; }
        public Nullable<System.DateTime> supply_examine_date { get; set; }
        public Nullable<System.DateTime> operator_date { get; set; }
    }
}
