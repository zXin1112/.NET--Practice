using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    class MyData : IData//实现接口
    {
        int Mem;
        public void SetData(int x)//实现方法
        {
            Mem = x;
        }
        public int  GetData()//实现方法
        {
            return Mem;
        }
    }
}
