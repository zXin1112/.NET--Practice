using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERT类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型不兼容的类型转换
            string s = Console.ReadLine();
            double d = Convert.ToDouble(s);//转换为double类型
            int i = Convert.ToInt32(s);//转换为32位int类型
            Console.WriteLine(d );
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
