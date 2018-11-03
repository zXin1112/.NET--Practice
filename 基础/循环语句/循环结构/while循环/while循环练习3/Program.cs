using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入用户名和密码，只要用户名和密码不是admin，888888就提示错误，重新输入
            string yonghuming = "";
            string mima = "";
            while (yonghuming != "admin" || mima != "888888") 
            {
                Console.WriteLine("请输入用户名：");
                yonghuming = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                mima = Console.ReadLine ();
            }
            Console.WriteLine("登陆成功！");
            Console.ReadKey();
        }
    }
}
