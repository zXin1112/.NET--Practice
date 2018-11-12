using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class I2018:Interface1 
    {
        private string segeg;
        public string read1c//属性
        {
            get
            {
                return segeg;
            }
            set
            {
                this.segeg = value;
            }
        }
        private int sfs;
        public int wefwe
        {
            get
            {
                return sfs;
            }
            set
            {
                this.sfs = value ;
            }
        }

        public void A()
        {
            Console.WriteLine("\"");
        }

        public void B(string DD, int FF)
        {
            Console.WriteLine("讲话");

        }
    }
}
