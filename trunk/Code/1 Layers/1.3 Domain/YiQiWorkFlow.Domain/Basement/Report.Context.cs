﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YiQiEntities5 : DbContext
    {
        public YiQiEntities5()
            : base("name=YiQiEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Sys_Report> Sys_Report { get; set; }
        public DbSet<Sys_Report_Column> Sys_Report_Column { get; set; }
        public DbSet<Sys_Report_Marks> Sys_Report_Marks { get; set; }
    }
}
