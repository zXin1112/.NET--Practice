using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Tdx : Teacher
    {
        /// <summary>
        /// 二徒弟
        /// </summary>
        public override void Mugongzuo()
        {
            base.Mugongzuo();
            Console.WriteLine("雕刻");
        }
    }
}
