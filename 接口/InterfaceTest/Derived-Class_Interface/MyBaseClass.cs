using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derived_Class_Interface
{
    class MyBaseClass : IIfc1//基类实现接口
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("String: {0}", s);
        }
    }
}
