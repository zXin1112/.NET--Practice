using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interfaces
{
    interface IDataStore//接口声明
    {
        //成员
        void SetData(int x);
        void PrintOut(string s);
    }
}
