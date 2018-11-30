using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型结构
namespace Generic_Struct
{
    struct PieceOfData<T>//声明结构
    {
        public PieceOfData(T Value)
        {
            _value = Value;
        }
        private T _value;

        public T Value { get => _value; set => _value = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PieceOfData<int> intPieceOfData = new PieceOfData<int>();
            intPieceOfData.Value = 1;//赋值
            PieceOfData<int> intPieceOfData1 = intPieceOfData;//赋值
            PieceOfData<string> stringPieceOfData = new PieceOfData<string>();
            stringPieceOfData.Value = "hello";//赋值
            Console.WriteLine("intPieceOfData:{0}", intPieceOfData.Value);
            Console.WriteLine("intPieceOfData1:{0}", intPieceOfData1.Value);
            Console.WriteLine("stringPieceOfData:{0}", stringPieceOfData.Value);
            Console.ReadKey();
        }
    }
}
