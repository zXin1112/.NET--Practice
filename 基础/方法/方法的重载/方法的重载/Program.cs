using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的重载指得是方法的名称相同，但参数不同。
            //参数不同分为两种情况
            //1 如果参数个数相同，那么参数类型就不能相同
            //2 如果参数类型相同，那么参数类型就不能相同

            int a=1;
            int c=2;
          double z=1;
            double s=3;
            string f="8";
            string g="9";
            M(a, c);
            M(z, s);
            M (f, g );
            Console.ReadLine();
        }
        public static void M(int x,int y)
        {
            int result=x+y ;
        }
        public static double M(double a,double s)
        {
            return a + s;
        }
        public static string       M(string d,string c)
        {
            return d + c;
        }
    }
}
