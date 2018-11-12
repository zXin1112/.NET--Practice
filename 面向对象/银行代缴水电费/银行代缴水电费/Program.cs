using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行代缴水电费
{
    class Program
    {
        static void Main(string[] args)
        {
            User p = new User("张三", "123456", "6534321", 100m, 100m);
            Console.WriteLine("请输入水费");
            decimal shui = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("请输入电费");
             decimal dian = Convert.ToDecimal(Console.ReadLine());
            Bank b = new Bank(shui, dian);
            string s = "0";
            while (true )
            {
                Console.WriteLine("输入1，交水费");
                Console.WriteLine("输入2，交电费");
                Console.WriteLine("输入3，水卡充值");
                Console.WriteLine("输入4，电卡充值");
                Console.WriteLine("输入5，退出");
                s = Console.ReadLine();
                 switch (s)
                 {
                     case "1": 
                        
                         b.jiaoshuifei(p);
                         break;
                     case "2":
                        
                         b.jiaodianfei(p);
                         break;
                     case "3":Console.WriteLine ("请输入要充值的金额");
                         shui =Convert .ToDecimal (Console .ReadLine ());
                         b.shuikachongzhi(shui, p);
                         break;
                     case "4": Console.WriteLine("请输入要充值的金额");
                         dian = Convert.ToDecimal(Console.ReadLine());
                         b.diankayuechongzhi(dian, p);
                         break;
                     default: break;
                 }
                 Console.ReadLine();
                 Console.Clear();
            }
          

        }
    }
}
