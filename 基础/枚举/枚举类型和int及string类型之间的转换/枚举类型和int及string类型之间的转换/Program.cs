using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举类型和int及string类型之间的转换
{
    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //QQState state = QQState.OnLine;
            ////枚举类型转换可以跟int类型相互转换   枚举类型跟int类型是兼容的
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.ReadKey();
            #endregion

            #region 将int转换成枚举类型
            //int n1 = 3;
            //QQState stat = (QQState)n1;
            //Console.WriteLine(stat);
            //Console.ReadKey();
            #endregion

            //所有类型都能转换成string类型
            #region 将枚举类型转成字符串类型
            //int n1 = 10;
            QQState stat = QQState.Leave;
            string s = stat.ToString();
            Console.WriteLine(s);
            Console .ReadKey ();
            #endregion
        }
    }
}
