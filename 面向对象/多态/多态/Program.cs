using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            MU mj;//接口
            string s = "0";
            while (s != "4")
            {
                Console.WriteLine("1,师傅");
                Console.WriteLine("2，大师兄");
                Console.WriteLine("3，二师兄");
                Console.WriteLine("4，退出");
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        mj = new Teacher();
                        mj.Mugongzuo();
                        break;
                    case "2":
                        mj = new Td();
                        mj.Mugongzuo();
                        break;
                    case "3":
                        mj = new Tdx();
                        mj.Mugongzuo();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}
