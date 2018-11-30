using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型类
namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            GenClass<int> intClass = new GenClass<int>(5);//使用
            GenClass<string> stringClass = new GenClass<string>("hello");
            Console.WriteLine("intClass:{0}", intClass.X);
            Console.WriteLine("stringClass:{0}",stringClass.X);
            Console.ReadKey();
        }
    }
    class GenClass<T>//声明泛型类
    {
       private T _x;
        public GenClass(T x)//构造函数
        {
            _x = x;
        }
        public T X { get => _x; set => _x = value; }
    }
}
