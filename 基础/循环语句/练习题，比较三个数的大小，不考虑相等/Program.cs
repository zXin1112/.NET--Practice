using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题_比较三个数的大小_不考虑相等
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字：");
            int c = Convert.ToInt32(Console.ReadLine());
            //第一种方法
            if ((a > b) && (a > c))//第一个数字大于第二第三个数字，则第一个数字最大
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b > c))//与上同理
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
            //第二种方法
            if (a > b)//先让第一个数字与第二个数字比较，若大于，则
            {
                if (a > c)//让其与第三个数字比较，求得最大的数字
                {
                    Console.WriteLine(a);
                }
                else //若不大于，说明第一个数大于第二个数，但小于第三个数，所以此时第三个数最大
                {
                    Console.WriteLine(c);
                }
            }
            else //此情况说明第二个数大于第一个数
            {
                if (b > c)//让第二个数与第三个数比较，求最大值
                {
                    Console.WriteLine(b);
                }
                else //此时说明第三个数大于第二个数且大于第一个数
                {
                    Console.WriteLine(c);
                }
            }
            Console.ReadKey();     
           
        }
    }
}
