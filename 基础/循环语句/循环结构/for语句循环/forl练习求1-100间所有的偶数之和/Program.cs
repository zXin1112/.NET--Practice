using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forl练习求1_100间所有的偶数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1-100的偶数和
            int a=0;
            for (int i = 1; i <101 ; i++)
            {
                if (i %2==0)
                {
                     a=a+i ;
                }

            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
