using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题__输入密码_提示成功与否
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入密码，若密码为888888则正确，否则要求再输入一次
            Console.WriteLine("请输入密码：");
            string mima = (Console.ReadLine());
            if (mima =="888888")//比较密码是否正确
            {
                Console.WriteLine("登陆成功！！！");
            }
            else //要求用户再输入一次
            {
                Console.WriteLine("密码错误，请再输入一次！");
                mima = Console.ReadLine();
                if (mima =="888888")
                {
                    Console.WriteLine("密码正确，登陆成功！！！");
                }
                else
                {
                    Console.WriteLine("密码再次错误，程序退出！");
                }
            }
            Console.ReadKey();
        }
    }
}
