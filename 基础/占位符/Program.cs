using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "卡卡西";
            string zhuzhi = "火影村";
            int age = 30;
            string youxiang = "kakaxi@qq.com";
            decimal gongzi = 2000m;
            Console.WriteLine("我叫{0}，我来自{1}，我今年{2}岁了，我的邮箱是{3}，我的工资是{4}",name,zhuzhi ,age ,youxiang ,gongzi );
            Console.ReadKey();
        }
    }
}
