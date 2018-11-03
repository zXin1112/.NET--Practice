using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出100内所有素数
            //素数，只能被1和这个数字本身整除的数,质数从2开始
            for (int i = 2; i < 101;i ++)
            {
                bool b = true;
                 for (int j = 2; j < i ; j++)
			    {
			        if (i %j==0)
                    {
                        b = false;
                        break;
                    }
			    }
                if (b )
                 Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
