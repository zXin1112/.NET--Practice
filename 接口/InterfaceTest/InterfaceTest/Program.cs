using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//接口的简单实现
namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { SValue = "object" };//创建对象
            myClass.PrintOut();//使用实现的方法
            //接口是引用类型，可将对象强制转为接口的类型，获取指向接口的引用
            MyClass myClass1 = new MyClass() { SValue = "myInterface" };//创建对象
            //IMyInterface myInterface = (IMyInterface)myClass1;//强制转换的方式
            IMyInterface myInterface = myClass1 as IMyInterface;//使用as运算符
            //两种方式效果相同
            if (myInterface != null)
            {
                myInterface.PrintOut();
            }

            Console.ReadKey();
        }
    }
}
