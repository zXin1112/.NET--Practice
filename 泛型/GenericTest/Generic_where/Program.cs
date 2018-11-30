using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型约束，where子句
namespace Generic_where
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型约束可以是
            //类名  这个类型的类或继承他的类
            //class 任何引用类型 包括类，数组，委托，接口
            //struct 任何值类型
            //接口名 只有这个接口或实现这个接口的类型的
            //new（）任何带有无参公共构造函数的
            MyClass<int, Customer, string[], bool, IMyFac, Customer_ch> myClass = new MyClass<int, Customer, string[], bool, IMyFac, Customer_ch>();//T1无约束
        }
    }
  
    class Customer:IMyFac { }
    class Customer_ch : Customer {
        public Customer_ch() { }
    }
    interface IMyFac { }
    //以泛型类为例
    class MyClass<T1,T2,T3,T4,T5,T6>
        where T2:Customer
        where T3 : class
        where T4:struct
        where T5:IMyFac
        where T6:new()
    {                     }
}
