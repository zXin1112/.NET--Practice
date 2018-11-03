using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产生随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true )
            {
                Random r = new Random();
                int rNumber =r.Next (1,11);
                Console.WriteLine(rNumber);
                Console.ReadKey ();
            }
        }
    }
}
