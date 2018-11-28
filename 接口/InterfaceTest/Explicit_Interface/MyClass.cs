using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface
{
    class MyClass:IIfc1,IIfc2//实现接口
    {
         void IIfc1.PrintOut(string s)//显式实现
        {
            Console.WriteLine("IIfc1:{0}", s);
        }
        void IIfc2.PrintOut(string s)//显式实现
        {
            Console.WriteLine("IIfc2:{0}", s);
        }
        public void Method(string s)
        {
            ((IIfc1)this).PrintOut(s);//实现类内部访问显式实现成员
        }
    }
}
