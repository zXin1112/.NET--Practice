using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//显式接口
namespace Explicit_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();//创建对象
            myClass.Method("myClass");//访问显式接口成员
            IIfc1 ifc1 = myClass as IIfc1;//获取iifc1的引用
            IIfc2 ifc2 = myClass as IIfc2;//获取iifc2的引用
            ifc1.PrintOut("interface1");
            ifc2.PrintOut("interface2");//调用显式实现方法
            Console.ReadKey();
        }
    }
}
