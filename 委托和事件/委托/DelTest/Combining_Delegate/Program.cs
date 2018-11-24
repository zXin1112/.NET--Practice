using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combining_Delegate
{
    delegate int MyDel(int x);
    class Program
    {
        int  Add2(int x)
        {
            return x += 2;
        }
        int Add3(int x)
        {
            return x += 3;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MyDel myDel1 = new MyDel(program.Add2);
            MyDel myDel2 = new MyDel(program.Add3);
            MyDel myDel = myDel1 + myDel2;//组合委托
            //委托对象创建后无法改变
            Console.WriteLine("Value:{0}", myDel(2));

            MyDel delVar= new MyDel(program.Add2);
            delVar += program.Add3;
            delVar += program.Add2;//为委托添加方法

            delVar -= program.Add3;//为委托移除方法
            Console.WriteLine("Value:{0}", delVar(2));
            Console.ReadKey();
        }
    }
}
