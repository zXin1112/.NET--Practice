using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Classes
{
    class Dog : Animal, ILiveBirth//继承基类，实现接口
    {
        public string BabyCalled()
        {
            return "Puppy";
        }
    }
}
