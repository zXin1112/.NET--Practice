using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快递员
{
    class Kuaidi:HUO 
    {
        public Kuaidi (double huoz,double g,double q):base(huoz )
        {
            this.G = g;
            this.Q = q;
        }
        private double G;

        public double G1
        {
            get { return G; }
            set { G = value; }
        }
        private double Q;

        public double Q1
        {
            get { return Q; }
            set { Q = value; }
        }
          public void JS( )
        {
              if (HuoZ1 <=10)
              {
                  Console.WriteLine("收费十元");
                  Console.ReadKey();
              }
              else
              {
                  this.Q = (HuoZ1 - 10) * 1.5 + 10;
                  Console.WriteLine("应收{0}元", this.Q);
                  Console.ReadKey();
              }
        }
    }
}
