using Lianxi.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianxi.SERVRCE
{
    class Add
    {
        private static BindingList<Commodity> _Commoditys = new BindingList<Commodity>();

        public static BindingList<Commodity> Commoditys
        {
            get { return Add._Commoditys; }
        }
        public int add(Commodity c)
        {
            Add._Commoditys.Add(c);
            return 1;
        }
    }
}
