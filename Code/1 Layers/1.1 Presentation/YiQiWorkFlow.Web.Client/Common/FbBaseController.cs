using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Domain.Fb;

namespace YiQiWorkFlow.Web.Client.Common
{
    public class FbBaseController:Controller
    {
        public static FbPaBaseSet FbPaBaseSet
        {
            get
            {
                if (CacheHelper.GetCache("FbPaBaseSet") == null)
                {
                    CacheHelper.SetCache("FbPaBaseSet", XmlHelper.DeSerializeFrom(typeof(FbPaBaseSet), System.Web.HttpContext.Current.Server.MapPath("/Data/Cache/FbPaBaseSet.xml")), System.Web.HttpContext.Current.Server.MapPath("/Data/Cache/FbPaBaseSet.xml"));
                }
                return (FbPaBaseSet)CacheHelper.GetCache("FbPaBaseSet");
            }
        }
    }
}