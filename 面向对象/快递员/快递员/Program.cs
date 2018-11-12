using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快递员
{
    class Program
    {
        static void Main(string[] args)
        {
//            3、背景：快递员包装货物，计算价格，送货。
//设计类完成该活动。
//计费方法：10kg以内收费10元， 10kg以外每超过1kg增收1.5元
            Console.WriteLine("输入货物重量");
            double a = Convert.ToDouble(Console.ReadLine());
            Console .WriteLine ("请输入运送公里数");
            double c= Convert.ToDouble(Console.ReadLine());
            Kuaidi b = new Kuaidi(a, c, 0);
            b.JS();
            


        }
    }
}
