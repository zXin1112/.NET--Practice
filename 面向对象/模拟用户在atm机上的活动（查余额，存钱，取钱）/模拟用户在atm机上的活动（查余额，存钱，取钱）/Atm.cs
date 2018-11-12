using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟用户在atm机上的活动_查余额_存钱_取钱_
{
    class ATM
    {
        public ATM ()
        {
            this.bianhao = "";
            this.dizhi = "";
            this.zongyue = 0;
        }
        public ATM (string bianhao,string dizhi,decimal zongyue)
        {
            this.bianhao = bianhao;
            this.dizhi=dizhi ;
            this.zongyue = zongyue;
        }
        /// <summary>
        /// Atm机编号
        /// </summary>
        private string bianhao;

        public string Bianhao
        {
            get { return bianhao; }
            set { bianhao = value; }
        }
        /// <summary>
        /// ATM机地址
        /// </summary>
        private string dizhi;

        public string Dizhi
        {
            get { return dizhi; }
            set { dizhi = value; }
        }
        /// <summary>
        /// 总余额
        /// </summary>
        private decimal zongyue;

        public decimal Zongyue
        {
            get { return zongyue; }
            set { zongyue = value; }
        }
    }
}
