 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入用户名密码，不是admin，888888就一直提示密码错误，重新输入
            string y = "";
            string m = "";
            do
            {
                Console.WriteLine("请输入用户名：");
                y = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                m = Console.ReadLine();
            } while (y != "admin" || m != "888888");
            Console.WriteLine("登陆成功！");
            Console .ReadKey  ();

        }
    }
}
