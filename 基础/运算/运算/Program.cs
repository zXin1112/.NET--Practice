using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算半径为5的圆的面积和周长
            //等号两边的数据类型必须一样
            //int r = 5;
            //double area = 3.14*r*r;
            //double zhouchang = 2 * 3.14 * r;
            //Console.WriteLine("周长是{0}，面积是{1}", zhouchang, area);
            //Console.ReadKey();
            //某商店T恤的价格为35元一件，裤子为120元一条，
            //小明在该店买了3件T恤2条裤子请计算小明应付多少元？
            int t = 35;
            int kuzi = 120;
            Console .WriteLine ("小明应付{0}元",t*3+kuzi *2);
            double dazhehou=(t*3+kuzi *2)*0.88;//打8.8折后
            Console.WriteLine("小明打折后付{0}元", dazhehou);
            Console .ReadKey();
            //打8.8折后呢？


        }
    }
}
