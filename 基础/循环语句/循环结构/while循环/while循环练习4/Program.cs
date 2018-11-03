using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习4
{
    class Program
    {
        static void Main(string[] args)
       {
            //老师问学生，这道题你会了么《若学生答会了
            //则可以放学，若不会则老师在讲一遍，再问学生是否会了
            //直到学生会为止才能放学
            //但讲了十遍还不会，也要放学
            string da = "";
            int i=0;
            while (da !="yes"&&i <10)//此处用&&，由于||一真一假判定为真，所以i<10这个判定条件无法跳出循环
            {
                Console.WriteLine(@"老师讲了{0}遍问学生这道题你会了么？
学生答：",i+1);
                da =Console.ReadLine();
                i++;
                
            }
            Console.WriteLine("放学！");
            Console.ReadKey();
        }
    }
}
