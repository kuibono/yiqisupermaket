using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Web.Client.Common;

namespace YiQiWorkFlow.Web.Client.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetComboData()
        {
            Dictionary<string, string> searchOptions = new Dictionary<string, string>();
            string table = "";
            string valueColumn = "";
            string textColumn = "";
            for (int i = 0; i < Request.QueryString.Count; i++)
            {
                if (Request.QueryString.Keys[i].ToLower() == "_")
                {
                    continue;
                }
                if (Request.QueryString.Keys[i].ToLower() == "table")
                {
                    table = Request.QueryString[i].ToString();
                }
                else if (Request.QueryString.Keys[i].ToLower() == "valuecolumn")
                {
                    valueColumn = Request.QueryString[i].ToString();
                }
                else if (Request.QueryString.Keys[i].ToLower() == "textcolumn")
                {
                    textColumn = Request.QueryString[i].ToString();
                }
                else
                {
                    searchOptions.Add(Request.QueryString.Keys[i].ToLower(), Request.QueryString[i].ToString());
                }
            }
            
            string str_sql = string.Format("select {0} as value,{1} as text from {2}", valueColumn, textColumn, table);
            if (searchOptions.Count>0)
            {
                str_sql += " where ";
                foreach (var options in searchOptions)
                {
                    str_sql += string.Format("{0}='{1}' and", options.Key, options.Value);
                }
                if(str_sql.EndsWith("and"))
                {
                    str_sql = str_sql.Substring(0, str_sql.Length - 3);
                }
            }
            DataTable _tb = MyEnv.GetSqlHelper().ExecuteDataTable(CommandType.Text, str_sql);
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (DataRow row in _tb.Rows)
            {
                result.Add(row["value"].ToString(), row["text"].ToString());
            }
            return Json(result.Select(p => new { id = p.Key, text = p.Value }), JsonRequestBehavior.AllowGet);
        }

    }
}
