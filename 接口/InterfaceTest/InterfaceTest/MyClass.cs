using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class MyClass : IMyInterface//实现接口
    {
        public string SValue { get; set; }//实现属性


        public void PrintOut()//实现方法
        {
            Console.WriteLine("string {0}", SValue);
        }
    }
}
