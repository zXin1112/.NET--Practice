using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//接口继承
namespace Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MyData myData = new MyData();//创建对象
            myData.SetData(5);
            Console.WriteLine("Number: {0}",myData.GetData());//实现方法
            Console.ReadKey();
        }
    }
}
