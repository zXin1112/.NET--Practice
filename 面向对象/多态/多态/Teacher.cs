using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Teacher : MU
    {
        /// <summary>
        /// 师傅
        /// </summary>

        public virtual void Mugongzuo()
        {
            Console.WriteLine("木匠");
        }
    }
}
