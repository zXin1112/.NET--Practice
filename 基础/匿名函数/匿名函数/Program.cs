using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名函数
{
    class Program
    {
        public delegate void Delsay(string name);
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Sayhi("张三", p.sauchinese);
           //Delsay del = p.sauchinese;
            //del("zhangsan");

            //Delsay del = delegate(string name)
            //{
            //    Console.WriteLine("你好" + name);
            //};//匿名函数
            //del("zhangsan "); 
            Delsay del = (string name) =>
            {
                Console.WriteLine("你好" + name);
            };//lamda表达式，也是匿名函数，是匿名函数的一种简写
            Console.ReadKey();
        }
      public void Sayhi(string name,Delsay del)
        {
            del(name);
        }
        public void sauchinese(string name)
        {
            Console.WriteLine("你好" + name);
        }
        public void sayenglish(string name  )
        {
            Console.WriteLine("hi" + name);
        }
    }
}
