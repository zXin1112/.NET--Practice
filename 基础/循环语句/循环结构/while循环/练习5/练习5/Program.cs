using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个数字（假定输入的都是正整数）当输入end输出最大值
            string a = "";
            int max = 0;
            while (a !="end")
            {
                Console.WriteLine("请输入一个数字，输入end我们将显示最大值");
                a = Console.ReadLine();//输入的可能是数字，end，或者其他
                if (a!="end")
                {
                    try
                    {
                        int n = Convert.ToInt32(a);
                        if (n > max)
                        {
                            max = n;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串有误");
                    }
                }
                else //a=end
                {
                    Console.WriteLine("输入的数字中最大值是{0}", max);
                }
                Console.ReadKey();
            }
        }
    }
}
