using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiQiWorkFlow.Domain.Basement
{
    public class SearchResult<T>
    {
        public int total { get; set; }

        public IList<T> data { get; set; }

        public object Statistics { get; set; }

    }
}
