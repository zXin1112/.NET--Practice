using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//标准事件
namespace EvevtTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();//发布者
            Dozens dozens = new Dozens(incrementer);//订阅者
            incrementer.DoCount();//执行方法，达成一定条件触发事件
            Console.WriteLine("Number：{0}", dozens.Dozensount);//触发的事件改变了订阅者类中的属性
            Console.ReadKey();
        }
    }
    class Incrementer//发布者
    {
       public delegate void Handler();
        public event Handler Event_Test;//自定义委托类型的事件
        public event EventHandler CountedADozen;//系统定义委托的事件
        public void DoCount()
        {
            for (int i = 1; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                {//每计数12后触发一次事件，触发事件前先确定是否注册
                    CountedADozen(this, null);
                    Event_Test();
                }
        }
    }
    class Dozens//订阅者
    {
        public int Dozensount { get; private set; }
        public Dozens(Incrementer incrementer)//构造函数
        {
            Dozensount = 0;
            incrementer.CountedADozen += IncrementDozensCount;//订阅事件
            incrementer.Event_Test += () =>
                Console.WriteLine("Enevt_Test");
            //Lambda表达式订阅的事件
        }
        void IncrementDozensCount(object s,EventArgs e)//事件处理程序
        {
            Dozensount++;
        }
    }
}
