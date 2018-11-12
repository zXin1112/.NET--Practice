using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //可接受任意个同类型参数，单一个方法只允许有一个参数，只能放在方法的最后
            patTest(1, 2, 3, 4);
            Console.ReadKey();
        }
        public static void patTest(params int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
