using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q时程序退出
           string a="";
            do
            {
                Console.WriteLine("请输入一个数字：");
                a=Console .ReadLine ();
                if (a!="q")
                {
                   int  s=Convert .ToInt32 (a);
                    Console .WriteLine ("输入的数字的2倍是{0}",s*2);
                }
                else //此时输入的为q
                {
                    Console .WriteLine ("输入的字符为q，程序退出！");
                }
             
                }
            } while (a);
            Console.ReadKey();
        }
    }
}
