using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YiQiWorkFlow.Domain.Basement
{
    public class GoodsClassTreeDto
    {
        public string id { get; set; }

        public string text { get; set; }

        public string pid { get; set; }
        public string type { get; set; }
        public string level { get; set; }

        public string value1 { get; set; }

        public string value2 { get; set; }

        public string[] valuesAry { set; get; }

        public GoodsClassTreeDto[] children { set; get; }
    }

    public class GoodsClassDto
    {
        public string id { set; get; }
        public string text { set; get; }
        public string pid { set; get; }
        public string type { set; get; }
        public string level { set; get; }
        public string value1 { set; get; }
        public string value2 { set; get; }
        //public string[] valuesStr { set; get; }
    }
}
