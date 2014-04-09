using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YiQiWorkFlow.Domain.Basement
{
    public class TreeValueDto
    {
        public string id { set; get; }
        public string text { set; get; }
        public string parentId { set; get; }
        public string type { set; get; }
        public string level { set; get; }
        public string value1 { set; get; }
        public string value2 { set; get; }
        public TreeValueDto[] children { set; get; }
    }
}
