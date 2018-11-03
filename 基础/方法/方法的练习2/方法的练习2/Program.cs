using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字的和
            //3、要求第一个数字必须比第二个数字小     
            Console.WriteLine("请输入第一个数字");
            string onenumber = Console.ReadLine();
            int numberone = A(onenumber);
            Console.WriteLine("请输入第二个数字");
            string twonumber = Console.ReadLine();
            int numbertwo = A(twonumber);
            //判断第一个数字和第二个数字的大小
            B (ref  numberone , ref numbertwo );
            //求和
            Console.WriteLine("{0}与{1}之间整数的和为{2}",numberone ,numbertwo , He(numberone, numbertwo));
            Console.ReadKey();

        }
        public static int A(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入的字符有误,请重新输入！！！");
                    s = Console.ReadLine();
                }

            }
        }
        public static void B(ref int n1,ref int n2)
        {
            if (n1 < n2)//此情况符合题意
            {
                return;
            }
            else //>=n2，不符合题意
            {
                Console.WriteLine("第一个数字不能大于或者等于第二个数字，请重新输入");
                string s1 = Console.ReadLine();//此时将s1重新赋值
                //调用字符转换的方法转换刚输入的字符
                n1 = A(s1);
                Console.WriteLine("请重新输入第二个数字");
                string s2 = Console.ReadLine();
                n2 = A(s2);
            }

        }
        public static int He(int n1,int n2 )
        {
            int sum = 0;
            for (int i = n1 ; i <= n2 ; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}