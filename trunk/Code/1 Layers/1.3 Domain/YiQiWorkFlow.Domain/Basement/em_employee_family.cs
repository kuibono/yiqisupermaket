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
    
    public partial class em_employee_family
    {
        public string em_code { get; set; }
        public string s_number { get; set; }
        public string member_name { get; set; }
        public string relationship { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string politics_code { get; set; }
        public string duty_code { get; set; }
        public string work_department { get; set; }
        public string Id { get; set; }
    
        public virtual em_employee_archives em_employee_archives { get; set; }
    }
}
