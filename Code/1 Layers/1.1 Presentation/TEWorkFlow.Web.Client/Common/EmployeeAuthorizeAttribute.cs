﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace TEWorkFlow.Web.Client.Common
{
    public class EmployeeAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var session = filterContext.HttpContext.Session;
            if (session == null || session[AuthorizeSettings.SessionUserType] == null || session[AuthorizeSettings.SessionUserType].ToString() != "0")
            {
                filterContext.Result = new RedirectResult("~/Account/Login");
            }
        }
    }
}