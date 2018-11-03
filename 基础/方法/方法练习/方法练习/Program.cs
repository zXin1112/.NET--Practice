using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取输入的整数，定义成方法，多次调用（如果用户输入的是
            //数字，则返回否则提示用户重弄新输入
            Console.WriteLine("请输入一个数字");
            string a = Console.ReadLine();
            GetNumber(a);
            Console.WriteLine("输入正确");
            Console.ReadKey();
        }
        public static int GetNumber(string s)
        {
            while (true )
            {
                try
                {

                    int number = Convert.ToInt32(s);
                    return number;

                }
                catch
                {
                    Console.WriteLine("请重新新输入");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
