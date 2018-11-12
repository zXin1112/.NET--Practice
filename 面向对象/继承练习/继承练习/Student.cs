using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
     class Student
    {
        public Student (string NAME,double AGE)
        {
           this .name =NAME  ;
          this .age = AGE;
        }
       

        protected string name;


        protected double age;

      
        public virtual void Show()
        {
            Console.WriteLine(@"名字是{0}，
今年{1}岁了", this.name, this.age);
        }
    }
}
 