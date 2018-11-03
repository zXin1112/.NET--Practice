using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 格式化数字字符串
{
    class Program
    {
        static void Main(string[] args)
        {
         double  a=525.3333;
          Console.WriteLine("{0},{1:c},{2,-10:c}", a, a,a );//对齐逗号，格式冒号,c为转化货币格式
          Console.WriteLine("|{0,10}|", a);//其中-10为左对齐，10为右对齐，0则居中
          Console.WriteLine("|{0,-10}|", a);
          Console.ReadKey();
        
        }
    }
}
