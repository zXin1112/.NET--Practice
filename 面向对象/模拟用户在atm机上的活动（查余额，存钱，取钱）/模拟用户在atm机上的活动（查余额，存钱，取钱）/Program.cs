using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟用户在atm机上的活动_查余额_存钱_取钱_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATM atm = new ATM();
            //atm.Bianhao = "666";
            //atm.Dizhi = "泰安";
            //atm.Zongyue = 100000000;
            ATM atm = new ATM("666", "泰安", 10000000m);

            //Usre user = new Usre();
            //user.Name  = "张鑫";
            //user.Mima = "666";
            //user.Zhanghao = "123456";
            //user.Yue = 1000;
            Usre user = new Usre("张鑫", "666", "123456", 1000m);
            bool b;
            do
            {
                Console.WriteLine("请输入用户名");
                string usrName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string usrPwd = Console.ReadLine();
                string msg;
                b = user.Denglu(usrName, usrPwd, out msg);
                Console.WriteLine("登录结果{0}", b);
                Console.WriteLine("登录信息{0}", msg);
            } while (b==false  );


            string s;
            while (true)
            {
                Console.WriteLine("输入1，查询余额");
                Console.WriteLine("输入2，存钱");
                Console.WriteLine("输入3，取钱");
                Console.WriteLine("输入4，退出");
                s = Console.ReadLine();
                decimal a = 0;

                switch (s)
                {
                    case "1": user.chayue();
                        break;
                    case "2": user.cunqian(a, atm);
                        break;
                    case "3": user.qvqian(atm, a);
                        break;
                    default: break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
