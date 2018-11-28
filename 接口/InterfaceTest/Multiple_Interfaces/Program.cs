using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//实现多个接口，实现具有重复成员的接口，多个接口引用
namespace Multiple_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyData myData = new MyData();
            myData.SetData(5);
            Console.WriteLine("Number: {0}", myData.GetData());

            myData.PrintOut("object");//实现重复成员
            //多个接口引用
            IDataRetrieve data1 = myData as IDataRetrieve;
            IDataStore data2 = myData as IDataStore;
            data1.PrintOut("data1");
            data2.PrintOut("data2");

            Console.ReadKey();
        }
    }
}
