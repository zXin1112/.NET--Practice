using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Jingtai
    {
        int Add()
        {
            return 0;
        }
        int Add(int x, int d)
        {
            return x + d;
        }
        int Add(int x, int d, int y)
        {
            return x + d + y;
        }
    }
}
