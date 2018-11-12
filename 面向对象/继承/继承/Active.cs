using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Active
    {
        private int ziyuan1;//子类无法调用private类型的变量

        public int Ziyuan1
        {
            get { return ziyuan1; }
            set { ziyuan1 = value; }
        }
        private int ziyuan2;

        public int Ziyuan2
        {
            get { return ziyuan2; }
            set { ziyuan2 = value; }
        }
        protected int ziyuan4;//此修饰词只能子类调用，其他类无法调用
        public void Account()
        {
            Console.WriteLine("唱歌");
        }
        public void Account2()
        {
            Console.WriteLine("跳舞");
        }
      public   virtual void Asd()//添加关键字vritual可令方法在子类中改动
        {
            Console.WriteLine("qqqq");
          
        }
    }
}
