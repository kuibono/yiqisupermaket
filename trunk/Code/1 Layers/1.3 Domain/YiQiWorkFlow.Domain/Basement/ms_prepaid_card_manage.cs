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
    
    public partial class ms_prepaid_card_manage
    {
        public string prepaid_number { get; set; }
        public string en_code { get; set; }
        public Nullable<System.DateTime> prepaid_date { get; set; }
        public string card_number { get; set; }
        public string surface_number { get; set; }
        public string ms_code { get; set; }
        public Nullable<decimal> prepaid_money { get; set; }
        public Nullable<decimal> total_prepaid { get; set; }
        public Nullable<decimal> current_prepaid { get; set; }
        public Nullable<decimal> use_prepaid { get; set; }
        public string card_code { get; set; }
        public string card_name { get; set; }
        public string card_state { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> operator_date { get; set; }
    }
}
