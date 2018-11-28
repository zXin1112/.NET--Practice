using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//多个类实现同一接口
namespace Different_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> {
                new Cat(),
                new Bird(),
                new Dog()
            };//将各个动物类添加到泛型集合中
            foreach (Animal item in animals)//遍历
            {
                ILiveBirth liveBirth = item as ILiveBirth;//转接口引用
                if (liveBirth != null)//若实现接口
                    Console.WriteLine("this is {0}", liveBirth.BabyCalled());//执行实现方法
            }
            Console.ReadKey();
        }
    }
}
