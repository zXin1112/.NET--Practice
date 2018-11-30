using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型方法
namespace Generic_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            ReverseAndPrint<string>(new string[] { "1", "2", "3" });
            ReverseAndPrint(arr);//这里编译器可 推断类型

            //扩展方法
            var intH = new Hodler<int>(1, 2, 3);
            var stringH = new Hodler<string>("1", "2", "3");
            intH.Print();
            stringH.Print();
            Console.ReadKey();
        }
        static public void ReverseAndPrint<T>(T[] arr)
        {//声明泛型方法
            Array.Reverse(arr);
            for (int i = 0, j = arr.Length; i < j; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
       
    }
    class Hodler<T>
    {
        T[] vals = new T[3];
        public Hodler(T t1, T t2, T t3)
        {
            vals[0] = t1;
            vals[1] = t2;
            vals[2] = t3;
        }
        public T[] GetValue() { return vals; }
    }
    static class ExtendHolder//静态类
    {
        public static void Print<T>(this Hodler<T> hodler)//this关键字和类型
        {
            T[] vals = hodler.GetValue();
            Console.WriteLine("{0},{1},{2}", vals[0], vals[1], vals[2]);
        }
    }

}
