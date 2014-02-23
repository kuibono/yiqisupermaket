using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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

        public ActionResult SaveImageToDb()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            string table = "";
            string imgColumn = "";
            string idColumn = "";
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
                else if (Request.QueryString.Keys[i].ToLower() == "imgcolumn")
                {
                    imgColumn = Request.QueryString[i].ToString();
                }
                else if (Request.QueryString.Keys[i].ToLower() == "idcolumn")
                {
                    idColumn = Request.QueryString[i].ToString();
                }
                else
                {
                    dic.Add(Request.QueryString.Keys[i].ToLower(), Request.QueryString[i].ToString());
                }
            }

            StringBuilder sql = new StringBuilder();
            string columnNames=imgColumn+","+idColumn+",";
            string columnVars = "@" + imgColumn + ",@" + idColumn + ",";


            foreach(var item in dic)
            {
                columnNames+=item.Key+",";
                columnVars+="@"+item.Key+",";
            }
            columnNames=columnNames.TrimEnd(',');
            columnVars=columnVars.TrimEnd(',');
            sql.AppendFormat("insert into {0}({1}) values({2})",table,columnNames,columnVars);

            List<SqlParameter> pars=new List<SqlParameter>();

            using(SqlCommand cmd=new SqlCommand(sql.ToString()))
            {
                SqlParameter param = new SqlParameter("@"+imgColumn,SqlDbType.VarBinary, Request.Files[0].ContentLength); 
                Stream ImageStream = Request.Files[0].InputStream;
                Byte[] ImageCount = new Byte[Request.Files[0].ContentLength];//调用方法转化二进制数据
                param.Value=ImageCount;
                pars.Add(param);
                //cmd.Parameters.Add(param);

                SqlParameter IdPar = new SqlParameter("@"+idColumn, SqlDbType.VarChar);
                IdPar.Value = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString();
                pars.Add(IdPar);

                foreach(var item in dic)
                {
                    SqlParameter par = new SqlParameter(item.Key,SqlDbType.VarChar); 
                    par.Value=item.Value;
                    //cmd.Parameters.Add(par);
                    pars.Add(par);
                }

                MyEnv.GetSqlHelper().ExecuteNonQuery(CommandType.Text,sql.ToString(),pars.ToArray());
                return Json(true,JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult GetImageFromDb()
        {
            string table = Request["table"];
            string imgcolumn = Request["imgcolumn"];
            string idColumn = Request["idcolumn"];
            string idValue=Request["idvalue"];
            string sql = string.Format("select {0} from {1} where {2}='{3}'",  imgcolumn,table, idColumn, idValue);
            byte[] buffer = (byte[])MyEnv.GetSqlHelper().ExecuteScalar(CommandType.Text, sql);
            if (buffer != null)
            {
                MemoryStream stream = new MemoryStream(buffer);
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                ImageResult result = new ImageResult(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                return result;
            }
            return null;
        }
    }
}
