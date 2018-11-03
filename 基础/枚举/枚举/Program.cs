using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    public enum Gender//声明了一个枚举
    {
        男,//两个值
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;//使用枚举
            Console.WriteLine(gender);
            Console.ReadKey();
        }
    }
}
