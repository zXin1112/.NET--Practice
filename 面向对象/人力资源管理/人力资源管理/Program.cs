using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 人力资源管理
{
    class Program
    {
        static void Main(string[] args)
        {
//应开发人力资源管理系统需要：
//试创建一个员工类，包含员工号、姓名、性别、身份证号、月工资5个属性；
//试创建一个管理员工信息的功能类，包含下列方法：
//添加员工；
//根据员工号删除员工；
//修改员工信息
//根据身份证求该员工的月工资；

            Function a = new Function();
            Staff b = new Staff();
           int  s=0;
          while (s <5)
          {
              Console.WriteLine("输入1，添加员工");
              Console.WriteLine("输入2，根据员工号删除员工");
              Console.WriteLine("输入3，修改员工信息");
              Console.WriteLine("输入4，根据身份证求该员工的月工资");
              Console.WriteLine("输入5，退出");
              s = Convert.ToInt32(Console.ReadLine());
              switch (s )
              {
                  case 1:
                      Console.WriteLine("请输入以下信息：");
                     a.TJ (b);
                      Console.ReadKey();
                      break;
                  case 2:
                      Console.Write("输入要删除的员工号：");
                      string c = Console.ReadLine();
                      a .SC (c ,b );
                      Console.ReadKey();
                      break;
                  case 3: a.XG (b );
                      Console.ReadKey();
                      break;
                  case 4:
                      Console.Write("请输入员工身份证号：");
                      string id = Console.ReadLine();
                      a.GZ (id ,b );
                      Console.ReadKey();
                      break;
                  default :
                      break;
              }
              Console.Clear();
          }
            Console.ReadKey();
        }
    }
}
