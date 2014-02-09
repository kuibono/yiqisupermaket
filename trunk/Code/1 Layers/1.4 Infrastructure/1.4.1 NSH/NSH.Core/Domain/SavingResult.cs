using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSH.Core.Domain
{
    public class SavingResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object ReturnObject { get; set; }
    }
}
