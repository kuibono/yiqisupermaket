using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YiQiWorkFlow.Web.Client.Common
{
    public class UserAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //var session = filterContext.HttpContext.Session;
            //if (session == null || session[AuthorizeSettings.SessionUserType] == null)
            //{
            //    string url = "/Account/Login";
            //    if (Common.MyEnv.IsHistoryEmloyee)
            //    {
            //        url = "/Account/ELogin";
            //    }
            //    filterContext.HttpContext.Response.Clear();
            //    filterContext.HttpContext.Response.Write("<script type='text/javascript'>top.location.href='" + url + "';</script>");
            //    filterContext.HttpContext.Response.End();
            //}
        }
    }
}