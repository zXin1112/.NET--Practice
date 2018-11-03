using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //某人工作评定，若为A级则涨500，
            //若为B则涨200
            //若为c则工资不变
            //若为d则降200
            //若为e则降500
            //设其原工资为5000，输入评级，显示工资
            //可用if  else
             //switch case
            Console.WriteLine("请输入评定等级");
            double a = 5000;
            string d = Console.ReadLine();
            bool b = true ;
            switch (d )
            {
                case "A": a = a + 500;//也可用a+=500
                    break;
                case "B": a += 200;
                    break;
                case "C": 
                    break;
                case "D": a -= 200;
                    break;
                case "E": a -= 500;
                    break;
                default: Console.WriteLine("输入错误！");
                    b = false;
                    break;
            }
            if (b )
            {
                 Console.WriteLine("他的工资为{0}",a);
            }
           
            Console.ReadKey();
        }
    }
}
