using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态
{
   static  class Bank//静态的类无需建构造函数，可直接赋初值
    {
        private static string name="中国银行";

        public static string Name
        {
            get { return Bank.name; }
            set { Bank.name = value; }
        }

      
        private static decimal account;//其中account为静态的属性，所以只能用类名点出来，静态属性公用，所以一个对象调用更改后的值另一个对象调用时的值为上一个对象更改后的值

        public static decimal Account
        {
            get { return Bank.account; }
            set { Bank.account = value; }
        }
        public static  void show()
        {
            Console.WriteLine("{0}养老金余额是{1}", Bank .name  , Bank.account );
        }

    
        public static  void save(decimal money)
        {
            Bank.account += money;
        }
    }
}
