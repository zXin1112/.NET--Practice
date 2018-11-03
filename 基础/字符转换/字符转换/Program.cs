using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.parse(),,同console.toint32()作用相同
            //int.tryparse(string s,out  a),,,尝试着将一个字符转换成字符串
            //若成功则将转换后的值赋给out后面的变量，并且返回一个布尔类型的值TRUE
            //若失败则将out后面的变量赋0，并且返回一个布尔类型的值FALSE
            //例
            int a = 1;
            bool b = int.TryParse("123", out a);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
