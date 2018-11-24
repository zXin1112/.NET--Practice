using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaoYong_Delegate
{
    delegate void WuDel();
    delegate int IntDel();
    delegate int RefDel(ref int x);
    class Program
    {
        static void Main(string[] args)
        {
            WuDel_Class wuDel_Class = new WuDel_Class();
            //调用无参数的委托
            WuDel wuDel = wuDel_Class.Print1;
            wuDel += wuDel_Class.Print2;
            wuDel += wuDel_Class.Print1;//现在，委托的方法列表中有3个方法
            Console.WriteLine("无参委托：");
            if (null != wuDel)
                wuDel();
            else
                Console.WriteLine("委托为空");

            IntDel_Class intDel_Class = new IntDel_Class();
            //调用有返回值的委托
            IntDel intDel = intDel_Class.Add2;
            intDel += intDel_Class.Add3;
            intDel += intDel_Class.Add2;
            Console.WriteLine("带返回值委托：");
            Console.WriteLine("Value:{0}", intDel());

            RefDel_Class refDel_Class = new RefDel_Class();
            //带引用参数的委托
            RefDel refDel = refDel_Class.Add2;
            refDel += refDel_Class.Add3;
            refDel += refDel_Class.Add2;
            int Intvalue = 5;
            refDel(ref Intvalue);//调用
            Console.WriteLine("带引用参数的委托：");
            Console.WriteLine("Value:{0}", Intvalue.ToString());
            Console.ReadKey();
        }
    }
    class WuDel_Class
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }
        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }
    class IntDel_Class
    {
        int intValue = 5;
        public int Add2()
        {
            intValue += 2;
            return intValue;
        }
        public int Add3()
        {
            intValue += 3;
            return intValue;
        }
    }
    class RefDel_Class
    {
        public int Add2(ref int x)
        {
            x += 2;
            return x;
        }
        public int Add3(ref int x)
        {
            x += 3;
            return x;
        }
    }
}
