using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelTest
{
    delegate void MyDel(int x);//声明委托
    class Program
    {
        void PrintLow(int value) {
            Console.WriteLine("Value:{0}", value);
        }
        void PrintHight(int value)
        {
            Console.WriteLine("Value:{0}", value);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MyDel myDel;//声明委托类型的变量

            Random random = new Random();
            int randomValue = random.Next(99);//生成随机数

            myDel = randomValue < 50 ? new MyDel(program.PrintLow) : new MyDel(program.PrintHight);//为委托变量赋值委托方对象
            myDel(randomValue);//执行委托

            Console.ReadKey();
        }
    }
}
