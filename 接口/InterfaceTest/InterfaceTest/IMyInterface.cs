using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    interface IMyInterface//声明接口
    {
      //成员
        string SValue { get; set; }
        void PrintOut();
    }
}
