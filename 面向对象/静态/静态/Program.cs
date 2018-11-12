using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.save(1000m);
            Bank.show();
            Console.ReadKey();
           
        }
     
    }
}
