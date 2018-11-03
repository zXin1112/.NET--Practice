using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="张鑫";
            char gender = '男';
            int age = 18;
            string dianhua = "1111111111";
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}", name, age, gender, dianhua);
            Console.ReadKey();
        }
    }
}
