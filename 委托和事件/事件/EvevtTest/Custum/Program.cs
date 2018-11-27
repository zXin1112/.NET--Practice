using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//自定义事件
namespace Custum
{
    class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();//发布者
            Dozens dozens = new Dozens(incrementer);//订阅者
            incrementer.DoCount();//满足条件时触发事件
            Console.WriteLine("Number：{0}", dozens.DozensCount);
            Console.ReadKey();
        }
    }
    class IncrementerEventArgs: EventArgs//自定义类,派生自EventArgs
    {
        public int IterationCount { get;  set; }
    }
    class Incrementer//发布者
    {
        public event EventHandler<IncrementerEventArgs> CountedADozen;//使用自定义类的泛型委托
        public void DoCount()
        {
            IncrementerEventArgs eventArgs = new IncrementerEventArgs();//自定义类对象
            for(int i=1;i<100;i++)
                if (i % 12 == 0 && CountedADozen != null)
                {
                    eventArgs.IterationCount = i;
                    CountedADozen(this, eventArgs);//触发事件
                }
        }
    }
    class Dozens//订阅者类
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount ;//注册事件
        }
        void IncrementDozensCount(object s,IncrementerEventArgs e)//处理程序
        {
            DozensCount++;
            Console.WriteLine("Incremented {0} in {1}", e.IterationCount, s.ToString());
        }
    }
}
