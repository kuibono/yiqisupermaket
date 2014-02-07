using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEWorkFlow.Domain.Demo;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass c = new TestClass();
            //c.Number = "aaa";
            c.Name = "bb";

            var result = c.GetValidateMessage();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
