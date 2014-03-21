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
namespace YiQiWorkFlow.Web.Client.Common
{
    public class MyEnv
    {
        private static IApplicationContext _applicationContext = ContextRegistry.GetContext();


        public static int CurentUserType
        {
            get
            {
                object session = System.Web.HttpContext.Current.Session[AuthorizeSettings.SessionUserType];
                if (session == null)
                {
                    return int.MinValue;
                }
                return Convert.ToInt32(session);
            }
        }

        public static bool IsHistoryEmloyee
        {
            get
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["userType"];
                if (cookie == null || cookie.Value == null)
                {
                    return false;
                }
                string value = cookie.Value.ToString();
                if (value == "e")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool IsHistorySupplier
        {
            get
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["userType"];
                if (cookie == null || cookie.Value == null)
                {
                    return false;
                }
                string value = cookie.Value.ToString();
                if (value == "s")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool IsEmployeeLogin
        {
            get
            {
                return CurentUserType == 0;
            }
        }
        public static bool IsSupplierLogin
        {
            get
            {
                return CurentUserType == 1;
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

    }



}