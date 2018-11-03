using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常：指语法上没有错误，在程序运行时由于某些原因程序出现错误，不能正常运行
            //解决办法，使用try-catch
            //实行过程，try中出现异常即使其后面有一百行代码，也不执行，直接跳到catch中执行
            //语法
            //try
            //{
            //    出现异常代码
            //        ...
            //           ...
            //               ...
            //}
            //catch 
            //{
            //    出现异常后要执行的代码
            //}
            //注：try中的变量作用域只在其括号内，所以一些必要的变量需在try外声明
           //try与catch之间紧密相连，不能出现其他代码 
            //例 
            bool b = true;//若输入错误类型的值，最后会多输出一个零，所以需要bool即布尔类型进行判定
            int number=0;//声明，应附初值
            Console.WriteLine("请输入一个数字");
           
            try
            {
                number = Convert.ToInt32(Console.ReadLine());//这只能转换数字，若用户输入字母，则报异常，，，，，赋值
                 
            }
            catch
            {
                Console.WriteLine("输入错误！");//此为输入字母时出现异常后要执行的代码
                b = false;
            }
            if (b==true )
            {
                 Console.WriteLine(number * 2);//使用
            }
           
            Console.ReadKey();
        }
    }
}
