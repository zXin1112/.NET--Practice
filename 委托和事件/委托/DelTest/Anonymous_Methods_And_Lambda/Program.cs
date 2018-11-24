using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods_And_Lambda
{
    delegate int MyDel(int x);
    class Program
    {
        static void Main(string[] args)
        {
            MyDel myDel = delegate (int x) { return x + 1; };//匿名方法
            MyDel del1 = (int x) => { return x + 1; };//Lambda表达式
            MyDel del2 = (x) => { return x + 1; };//Lambda表达式
            MyDel del3 = x => { return x + 1; };//Lambda表达式
            MyDel del4 = x => x + 1;//Lambda表达式
            Console.WriteLine("{0}", myDel(12));
            Console.WriteLine("{0}", del1(12));
            Console.WriteLine("{0}", del2(12));
            Console.WriteLine("{0}", del3(12));
            Console.WriteLine("{0}", del4(12));
            Console.ReadKey();
        }
    }
}
