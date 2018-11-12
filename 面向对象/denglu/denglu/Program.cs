using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denglu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string usermima = Console.ReadLine();
            string xinxi;
            bool a = denglu(username, usermima, out xinxi);
            Console.WriteLine("登录结果{0}", a);
            Console.WriteLine("登录信息{0}", xinxi);
            Console.ReadKey();


        }
        public static  bool denglu(string name,string mima,out string xinxi)
        {
            if (name == "zhaozhao" && mima == "666")
            {
                xinxi = "登录成功";
                return true;
            }
            else if (name == "zhaozhao")
            {
                xinxi = "密码错误";
                return false;
            }
            else if (mima == "666") 
            {
                xinxi ="用户名错误";
                return false;
            }
            else 
            {
                xinxi ="全部错误";
                return false ;
            }

        }
    }
}
