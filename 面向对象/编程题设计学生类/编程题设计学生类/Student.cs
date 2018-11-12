using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编程题设计学生类
{
    class Student
    {
        public Student ()//无参数
        {
            this.Name = "";
            this.Achievement = "";
        }
       public Student (string Name,string Achievement)//接受参数
        {
            this.Name = Name;
            this.Achievement = Achievement;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string achievement;

        public string Achievement
        {
            get { return achievement; }
            set { achievement = value; }
        }
    }
}
