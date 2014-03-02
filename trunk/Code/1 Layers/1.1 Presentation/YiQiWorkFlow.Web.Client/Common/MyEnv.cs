﻿using System;
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
            NameValueCollection cfgName = (NameValueCollection)ConfigurationSettings.GetConfig("databaseSettings");;
            string connStr = cfgName["db.connectionString"].ToString();
            return new SqlHelper(connStr);
        }

        #endregion

        /// <summary>
        /// 获取某表的流水号
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static int GetTableSerialNumber(string table)
        {
            try
            {
                return (int)GetSqlHelper().ExecuteScalar(CommandType.Text, string.Format("update sys_SerialNumber set SerialNumber=SerialNumber+1 where tablename='{0}';select SerialNumber from sys_SerialNumber where tablename='{0}'", table));
            }
            catch
            {
                string sql = string.Format("insert into sys_SerialNumber(tablename,SerialNumber) values('{0}',0)",table);
                GetSqlHelper().ExecuteNonQuery(CommandType.Text, sql);
                return GetTableSerialNumber(table);
            }
        }
    }

   
    
}