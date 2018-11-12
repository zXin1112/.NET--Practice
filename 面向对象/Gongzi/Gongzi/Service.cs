using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gongzi
{
    class Service
    {
        private static BindingList<Gongzi> _Jilu = new BindingList<Gongzi>();

        public static BindingList<Gongzi> Jilu
        {
            get { return Service._Jilu; }
            set { Service._Jilu = value; }
        }
        private static Hashtable _Gongzis = new Hashtable();

        public static Hashtable Gongzis
        {
            get {
                if (Service ._Gongzis .Count ==0)
                {
                    Service._Gongzis.Add("项目", new String[] { "工资", "房租", "水电", "饭费", "电话费", "其它开销" });
                    
                }
                return Service._Gongzis; }
            
        }


        public int Add(Gongzi g)
        {
            Service._Jilu.Add(g);
            return 1;
        }
    }
}
