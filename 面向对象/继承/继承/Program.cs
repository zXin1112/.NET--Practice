using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //继承，子类(派生类）继承父类（基类）格式
            //class 子类名：父类名
            //    子类中会自动拥有父类里面的，属性方法
            //一个基类可以有多个直接派生类
            //继承可以传递的  例 class B:A     class C:B
            Active2017 a2017 = new Active2017();
            a2017.Account();
            a2017.Account2();
            a2017.Asd();
            Console.ReadKey();
        }
    }
}
