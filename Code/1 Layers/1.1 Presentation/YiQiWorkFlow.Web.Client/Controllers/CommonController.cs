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
            string table = Request.QueryString["table"];
            string valueColumn = Request.QueryString["valueColumn"];
            string textColumn = Request.QueryString["textColumn"];
            string filter = Request.QueryString["filter"];
            string str_sql = string.Format("select {0} as value,{1} as text from {2}", valueColumn, textColumn, table);
            if (string.IsNullOrEmpty(filter) == false)
            {
                str_sql += " where " + filter;
            }
            DataTable _tb = MyEnv.GetSqlHelper().ExecuteDataTable(CommandType.Text, str_sql);
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (DataRow row in _tb.Rows)
            {
                result.Add(row["value"].ToString(), row["text"].ToString());
            }
            return Json(result.Select(p => new { value = p.Key, text = p.Value }), JsonRequestBehavior.AllowGet);
        }

    }
}
