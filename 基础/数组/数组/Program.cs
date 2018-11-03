using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的定义
            // int[] x = new int[100];
            int[] x;
            x = new int[100];
            int[] arr = { 6,5,4,3,2,1 };
            //常见操作
            //遍历
            Console.WriteLine("for遍历");
            for (int i = 0, j=arr.Length; i < j; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("foreach遍历");
            foreach (var item in arr)
            {
                Console.Write(item.ToString()+" ");
            }
            Console.WriteLine("");
            //排序
            Console.WriteLine("冒泡排序");
            arr = sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item.ToString()+" ");
            }
            Console.WriteLine("");
            //多维数组
            // int[,] arrs = new int[3,4];/
            // int[,] arrs = new int[3, 4] { { 1,2,3,4} ,{5,6,7,8 },{ 9,10,11,12} };
            int[,] arrs ={ { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };// 二维数组，第一维长度为3，第二维擦汗能高度为4
            Console.WriteLine("多维数组遍历");
            for (int i = 0; i < arrs.GetLength(0); i++)
            {
                for (int j = 0; j < arrs.GetLength(1); j++)
                {
                    Console.Write(arrs[i, j]+" ");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="data">排序的数组</param>
        /// <returns></returns>
       static public int[] sort(int[] data) {
          
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length-1-i; j++)
                {
                    if (data[j] > data[j + 1]) {
                        int temp = data[j];
                        data[j] = data[j+ 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
    }
}
