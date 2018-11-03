using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入年份再输入月份输出该月天数
            Console.WriteLine("请输入年份：");
            try
            {
                int nianfen = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份：");
                try
                {
                    int yuefen = Convert.ToInt32(Console.ReadLine());
                    if (yuefen > 1 && yuefen < 12)//若输入大于12的月份程序也会进行，但逻辑说不通你所以限制月份的范围
                    {
                        int day;//声明一个变量储存天数
                        switch (yuefen)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31;//1 3 5 7 8 10 12月份都是31天所以这样写
                                break;
                            case 2://2月的天数由年份是否为闰年决定
                                if ((nianfen % 400 == 0) || (nianfen % 4 == 0 && nianfen % 100 != 0))//判定闰年
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default: day = 30;//此情况为除以上的所有情况即4 6 9 11月份
                                break;
                        }

                        Console.WriteLine("{0}年{1}月份有{2}天", nianfen, yuefen, day);
                    }//if 的括号
                    else
                    {
                        Console.WriteLine("月份输入有误！");
                    }
                }//月份的try
                catch
                {
                    Console.WriteLine("输入的月份有误，程序退出！");
                }
            }//年份的try
            catch
            {
                Console.WriteLine("输入的年份有误，程序退出！");
            }

            Console.ReadKey();
        }
    }
}
