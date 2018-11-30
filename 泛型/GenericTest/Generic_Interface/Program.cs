using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型接口
namespace Generic_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型接口的实现保证唯一性
            MyClass<string> stringMyClass = new MyClass<string>();
            MyClass<int> intMyClass = new MyClass<int>();
            Console.WriteLine("{0}", stringMyClass.Print("hello"));
            Console.WriteLine("{0}", intMyClass.Print(5555));
            Console.ReadKey();
        }
    }
    interface ImyIfac<T>//声明接口
    {
         T Print(T value);
    }
    class MyClass<S> : ImyIfac<S>//实现
    {
        public S Print(S value)
        {
            return value;
        }
    }
}
