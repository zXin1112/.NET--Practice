using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//派生类实现接口
namespace Derived_Class_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();//派生类对象
            derived.PrintOut("object");//调用实现方法
            Console.ReadKey();
        }
    }
}
