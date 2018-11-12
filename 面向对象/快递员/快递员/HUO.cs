using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快递员
{
    class HUO
    {
        public HUO ()
        {

        }
        public HUO (double huoz)
        {
            this.HuoZ = huoz;
        }
        private double  HuoZ;

        public double HuoZ1
        {
            get { return HuoZ; }
            set { HuoZ = value; }
        }

    }
}
