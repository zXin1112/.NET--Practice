using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理
{
    class Program
    {
        static void Main(string[] args)
        {
//  2、某公司的仓库管理系统：
//试创建一个仓库类（假设一个仓库只存储一种货物），创建仓库号，仓库地址，剩余面积，货物名称 4个属性；
//    创建4属性的构造函数；
//      创建一个入库方法，根据入库货物面积重新计算剩余面积；
//      创建一个显示仓库信息的方法。
//试创建一个危险品仓库类，比仓库类多危险品等级属性；
//     创建5属性的构造函数；需创建显示危险品仓库信息的方法。

            Warehouse a = new Warehouse("123", "山东省", 190, "食物");
            Console.WriteLine("输入用户入库货物面积");
            double s = Convert.ToDouble(Console.ReadLine());
            a.RK(s);
            Console.WriteLine("输入回车，查询信息");
            Console.ReadLine();
            a.CX();
            Console.ReadKey();
            Console.WriteLine("显示危险仓库信息");
            Danderous b = new Danderous("1234", "山东省", 444, "炸药", "4");
            b.CX();
            Console.ReadKey();



        }
    }
}
