using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSH.Core.Domain.Validate
{
    /// <summary>
    /// 验证结果
    /// </summary>
    public class ValidateResult
    {
        private bool _IsSuccess = true;
        public bool IsSuccess
        {
            get { return _IsSuccess; }
            set { _IsSuccess = value; }
        }

        private List<string> _Messages = new List<string>();
        public List<string> Messages { get { return _Messages; } set { _Messages = value; } }

        public void AddMessage(string message)
        {
            this.Messages.Add(message);
            this.IsSuccess = false;
        }
    }
}
