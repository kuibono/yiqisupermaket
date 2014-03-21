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
        #region View
        public ActionResult GoodsSelector()
        {
            return View();
        }

        public ActionResult GoodsClassSelector()
        {
            return View();
        }

        public ActionResult EnterpriseArchivesSelector()
        {
            return View();
        }

        public ActionResult MemberArchivesSelector() { return View(); }

        public ActionResult CardArchivesSelector() { return View(); }

        #endregion View

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
            if (searchOptions.Count > 0)
            {
                str_sql += " where ";
                foreach (var options in searchOptions)
                {
                    str_sql += string.Format("{0}='{1}' and", options.Key, options.Value);
                }
                if (str_sql.EndsWith("and"))
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
            string typeColumn = "";
            string numberColumn = "";
            foreach (var item in Request.GetData())
            //for (int i = 0; i < Request.GetData().Count; i++)
            {
                //Request.GetData()[i].
                if (item.Key.ToLower() == "_"
                    || item.Key.ToLower() == "filename"
                    || item.Key.ToLower() == "0"
                    || item.Key.ToLower() == "1"
                    || item.Key.ToLower() == "2"
                    || item.Key.ToLower() == "3"
                    || item.Key.ToLower() == "4"
                    || item.Key.ToLower() == "5"
                    || item.Key.ToLower() == "6"
                    || item.Key.ToLower() == "7"
                    || item.Key.ToLower() == "escapedatetimetokens"
                    || item.Key.ToLower() == "upload"
                    )
                {
                    continue;
                }

                if (item.Key.ToLower() == "table")
                {
                    table = item.Value.ToString();
                }
                else if (item.Key.ToLower() == "imgcolumn")
                {
                    imgColumn = item.Value.ToString();
                }
                else if (item.Key.ToLower() == "idcolumn")
                {
                    idColumn = item.Value.ToString();
                }
                else if (item.Key.ToLower() == "typecolumn")
                {
                    typeColumn = item.Value.ToString();
                }
                else
                {
                    dic.Add(item.Key.ToLower(), item.Value.ToString());
                }
            }

            StringBuilder sql = new StringBuilder();
            string columnNames = imgColumn + "," + idColumn + ",";
            string columnVars = "@" + imgColumn + ",@" + idColumn + ",";
            if (string.IsNullOrEmpty(typeColumn) == false)
            {
                columnNames += typeColumn + ",";
                columnVars += "@" + typeColumn + ",";
            }
            //if (string.IsNullOrEmpty(numberColumn) == false)
            //{
            //    columnNames += numberColumn + ",";
            //    columnVars += "@" + numberColumn + ",";
            //}
            foreach (var item in dic)
            {
                columnNames += item.Key + ",";
                columnVars += "@" + item.Key + ",";
            }
            columnNames = columnNames.TrimEnd(',');
            columnVars = columnVars.TrimEnd(',');
            sql.AppendFormat("insert into {0}({1}) values({2})", table, columnNames, columnVars);

            List<SqlParameter> pars = new List<SqlParameter>();

            using (SqlCommand cmd = new SqlCommand(sql.ToString()))
            {
                SqlParameter param = new SqlParameter("@" + imgColumn, SqlDbType.VarBinary, Request.Files[0].ContentLength);
                Stream ImageStream = Request.Files[0].InputStream;

                Byte[] ImageCount = new Byte[Request.Files[0].ContentLength];//调用方法转化二进制数据
                Request.Files[0].InputStream.Read(ImageCount, 0, ImageCount.Length);
                param.Value = ImageCount;
                pars.Add(param);
                //cmd.Parameters.Add(param);

                SqlParameter IdPar = new SqlParameter("@" + idColumn, SqlDbType.VarChar);
                IdPar.Value = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString();
                pars.Add(IdPar);

                if (string.IsNullOrEmpty(typeColumn) == false)
                {
                    SqlParameter typePar = new SqlParameter("@" + typeColumn, SqlDbType.VarChar);
                    typePar.Value = Path.GetExtension(Request.Files[0].FileName).Replace(".", "");
                    pars.Add(typePar);
                }
                //if (string.IsNullOrEmpty(numberColumn) == false)
                //{
                //    SqlParameter numberPar = new SqlParameter("@" + numberColumn, SqlDbType.VarChar);
                //    numberPar.Value = MyEnv.GetSqlHelper().ExecuteScalar(CommandType.Text,string.Format("select max({0}) from "))
                //    pars.Add(numberPar);
                //}
                foreach (var item in dic)
                {
                    SqlParameter par = new SqlParameter(item.Key, SqlDbType.VarChar);
                    par.Value = item.Value;
                    //cmd.Parameters.Add(par);
                    pars.Add(par);
                }

                MyEnv.GetSqlHelper().ExecuteNonQuery(CommandType.Text, sql.ToString(), pars.ToArray());
                return Json(true, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult GetImageFromDb()
        {
            string table = Request["table"];
            string imgcolumn = Request["imgcolumn"];
            string idColumn = Request["idcolumn"];
            string idValue = Request["idvalue"];
            string sql = string.Format("select {0} from {1} where {2}='{3}'", imgcolumn, table, idColumn, idValue);
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

        public ActionResult ChangeDbValue()
        {
            string pkColumn = Request["pkcolumn"];
            string table = Request["table"];
            string[] pkValue = Request["pk"].Split(',');

            StringBuilder sb = new StringBuilder();
            StringBuilder sb_Set = new StringBuilder();
            StringBuilder ids = new StringBuilder();
            foreach (string pk in pkValue)
            {
                ids.AppendFormat("'{0}',", pk);
            }
            ids = new StringBuilder(ids.ToString().TrimEnd(','));

            foreach (var item in Request.GetData())
            {
                if (item.Key.ToLower() == "pkcolumn" || item.Key.ToLower() == "pk" || item.Key.ToLower() == "table" || item.Key.ToLower() == "_")
                {
                    continue;
                }
                sb_Set.AppendFormat("{0}='{1}',", item.Key, item.Value);
            }
            sb_Set = new StringBuilder(sb_Set.ToString().TrimEnd(','));
            sb.AppendFormat("update {0} set {1} where {2} in ({3})", table, sb_Set.ToString(), pkColumn, ids.ToString());

            try
            {
                MyEnv.GetSqlHelper().ExecuteNonQuery(CommandType.Text, sb.ToString());
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
