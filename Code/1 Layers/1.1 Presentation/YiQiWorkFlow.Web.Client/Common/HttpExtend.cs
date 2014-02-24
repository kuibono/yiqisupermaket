using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace YiQiWorkFlow.Web.Client.Common
{
    public static class HttpExtend
    {
        public static Dictionary<string,string> GetData(this HttpRequestBase request)
        {

            Dictionary<string, string> result = new Dictionary<string, string>();
            
            for (int i = 0; i < request.QueryString.Keys.Count; i++)
            {
                result.Add(request.QueryString.Keys[i], request.QueryString[i]);
            }
            for (int i = 0; i < request.Form.Keys.Count; i++)
            {
                result.Add(request.Form.Keys[i], request.Form[i]);
            }
            return result;
        }
    }
}