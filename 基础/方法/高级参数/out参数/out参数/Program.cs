using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //out 参数可传递多个值，在使用时参数无需赋值
            int max, min, sum;
            outTest(new int[5] { 2, 3, 1, 4, 5 },out max,out min,out sum);
            Console.WriteLine("max={0},min={1},sum={2}", max, min, sum);
            Console.ReadKey();
        }
        public static void outTest(int[] array, out int max, out int min, out int sum)
        {
            min = array[0];
            max = array[0];
            sum = array[0];
            for (int i = 1,j=array.Length; i < j; i++)
            {
                sum += array[i];
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
        }
    }
}
