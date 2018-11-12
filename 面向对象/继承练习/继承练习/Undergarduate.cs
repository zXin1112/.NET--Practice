using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Undergarduate : Student
    {
        public Undergarduate(string NAME,double AGE,string Degree) :base(NAME  ,AGE )//子类函数默认继承父类的无参构造函数，
        {
           
            this.degree = Degree;
        }
        private string degree;

      
        public override void Show()
        {
            base.Show();
            Console.WriteLine("学位是"+ this.degree);
        }
    }
}
