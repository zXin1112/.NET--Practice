using Fridend_Book.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fridend_Book.Service
{
    class Service1
    {
        private static BindingList<Friend> _Friends = new BindingList<Friend>();

        internal static BindingList<Friend> Friends
        {
            get { return Service1._Friends; }
            set { Service1._Friends = value; }
        }
        private static Hashtable _JGData = new Hashtable();

        public static Hashtable JGData
        {
            get
            {
                if (Service1._JGData.Count == 0)
                {
                    Service1._JGData.Add("省份", new String[] { "山东省", "河南省" });
                    Service1._JGData.Add("山东省", new String[] { "济南市", "烟台市","泰安市" });
                    Service1._JGData.Add("泰安市", new String[] { "泰山区", "岱岳区" });
                    Service1._JGData.Add("烟台市", new String[] { "蓬莱区", "芝罘区" });
                }

                return Service1._JGData;
            }
        }

       
        public int AddFriend(Friend f)
        {
            Service1._Friends.Add(f);
            return 1;
        }
        public int DelFriend(int index)
        {
            Service1._Friends.RemoveAt(index);
            return 1;       
            
        }
    }
}
