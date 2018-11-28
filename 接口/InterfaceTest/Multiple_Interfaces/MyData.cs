using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interfaces
{
    class MyData : IDataRetrieve, IDataStore//实现接口
    {
        int Mem1;
        public int GetData()//实现方法
        {
            return Mem1;
        }

        public void PrintOut(string s)//实现重复方法
        {
            Console.WriteLine("string：{0}", s);
        }

        public void SetData(int x)//实现方法
        {
            Mem1 = x;
        }
    }
}
