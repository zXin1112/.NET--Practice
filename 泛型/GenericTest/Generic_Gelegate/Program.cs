using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型委托
namespace Generic_Gelegate
{
    delegate void MyDelegate<T>(ref T value);//声明委托 有返回值
    delegate T MyDelegate1<T>( T value);//声明委托  无返回值
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1;
            MyDelegate<int> myDelegate = (ref int x) =>
             {
                 x++;
             };//给委托赋值
            MyDelegate1<decimal> myDelegate1 = x =>  x+100;//给委托赋值
            myDelegate(ref X);
            Console.WriteLine(X.ToString());//执行委托
            Console.WriteLine(myDelegate1(X).ToString());
            Console.ReadKey();
        }
    }
}
