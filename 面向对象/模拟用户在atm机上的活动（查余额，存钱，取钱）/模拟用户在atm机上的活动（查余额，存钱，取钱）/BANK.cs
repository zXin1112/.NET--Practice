using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟用户在atm机上的活动_查余额_存钱_取钱_
{
    class BANK
    {
        private static decimal yinhangyue;

        public static decimal Yinhangyue
        {
            get { return BANK.yinhangyue; }
            set { BANK.yinhangyue = value; }
        }
    }
}
