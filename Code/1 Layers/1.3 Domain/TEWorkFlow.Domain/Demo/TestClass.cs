using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TEWorkFlow.Domain.Basement;

namespace TEWorkFlow.Domain.Demo
{
    public class TestClass : DomainBase
    {
        [Validate(ValidateType.IsEmpty | ValidateType.IsNumber , Name="编号")]
        public int Number { get; set; }

        [Validate(ValidateType.MaxLength|ValidateType.MinLength, MaxLength = 30, MinLength = 10,Name="名称")]
        public string Name { get; set; }
    }
}
