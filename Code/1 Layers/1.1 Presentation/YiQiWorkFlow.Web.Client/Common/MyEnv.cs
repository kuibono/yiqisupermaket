using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spring.Context;
using Spring.Context.Support;
using Spring.Data.NHibernate.Generic;
using NSH.VSTO;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;
using YiQiWorkFlow.Domain.Basement;
using YiQiWorkFlow.Domain.Sys;
namespace YiQiWorkFlow.Web.Client.Common
{
    public class MyEnv
    {
        private static IApplicationContext _applicationContext = ContextRegistry.GetContext();


        public static SysLoginPower LoginUser
        {
            get
            {
                return new SysLoginPower { Id = "13964358278177780", EmName = "李明" };
            }
        }
        #region GetServices


        public static HibernateTemplate GetHibernateTemplate()
        {
            return (HibernateTemplate)_applicationContext.GetObject("HibernateTemplate");
        }

        public static SqlHelper GetSqlHelper()
        {
            NameValueCollection cfgName = (NameValueCollection)ConfigurationSettings.GetConfig("databaseSettings"); ;
            string connStr = cfgName["db.connectionString"].ToString();
            return new SqlHelper(connStr);
        }
        public static string GetConnectionString()
        {
            NameValueCollection cfgName = (NameValueCollection)ConfigurationSettings.GetConfig("databaseSettings"); ;
            return cfgName["db.connectionString"].ToString();
        }

        public static string GetEFConnectionString()
        {
            return string.Format("metadata=res://*/Basement.Report.csdl|res://*/Basement.Report.ssdl|res://*/Basement.Report.msl;provider=System.Data.SqlClient;provider connection string=\"data source=.;initial catalog=YiQi;persist security info=True;user id=sa;password=Admin@123;MultipleActiveResultSets=True;App=EntityFramework\"");
        }
        #endregion




        #region 检查记录是否在某表中存在
        /// <summary>
        /// 检查记录是否在某表中存在
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool RecordExist(string table, string column, string value, Dictionary<string, string> dic = null)
        {
            var split = value.Split(',');
            var result = "";
            foreach (string s in split)
            {
                result += "'" + s + "',";
            }
            result = result.TrimEnd(',');

            string strSql = string.Format("select count(0) from {0} where {1} in ({2})", table, column, result);
            if (dic != null)
            {
                foreach (var item in dic)
                {
                    strSql += string.Format(" and {0}=N'{1}'", item.Key, item.Value);
                }
            }

            return Convert.ToInt32(GetSqlHelper().ExecuteScalar(CommandType.Text, strSql)) > 0;
        }
        #endregion

        /// <summary>
        /// 默认打印纸宽度（cm）
        /// </summary>
        public int PagerWidth { get { return 21; } }

        public static string CheckStockType { get { return "2"; } }

        public static string EnType { get { return "2"; } }

    }



}