using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习_输入用户名_密码_验证正确与否
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入用户名，然后输入密码
            //若用户名是“admin”并且密码是888888，则提示正确
            //若用户名不是admin，提示用户名不存在
            //若荣户名是admin密码错误，提示密码错误
            //密码用户名都错误
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string mima = Console.ReadLine();
            if (name == "admin ")
            {
                if (mima == "888888")
                {
                    Console.WriteLine("登陆成功！！！");
                }
                else //此情况密码错误
                {
                    Console.WriteLine("密码错误！");
                }
            }
            else //此情况用户名错误
            {
                if (mima =="888888")
                {
                    Console.WriteLine("用户名不存在！");             
                }
                else //此时密码用户名都错误
                {
                    Console.WriteLine("用户名密码错误！！！");
                }
                Console.ReadKey();
            }
        }
    }
}
