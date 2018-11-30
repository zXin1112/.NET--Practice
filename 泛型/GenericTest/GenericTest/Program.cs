using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    //泛型类
    class Generic_Class<T>
    {
        private T _values;
        public Generic_Class(T values)
        {
            _values = values;
        }

        public T Values { get => _values; set => _values = value; }
    }
    //泛型结构
    struct PieceOfData<T>
    {
        public PieceOfData(T Value)
        {
            _value = Value;
        }
        private T _value;

        public T Value { get => _value; set => _value = value; }
    }
    //泛型接口
    interface IMyIfc<T>
    {
        T FunReturn(T value);
    }
    //泛型委托
    delegate TR MyDelegate<T, TR>(T t);
    class Program
    {
        static void Main(string[] args)
        {
            //C#提供了5种泛型：类、结构、接口、委托和方法
        }
        //泛型方法
        public static T  GetTR<T>(T t1)
        {

            return t1;
        }
    }
}
