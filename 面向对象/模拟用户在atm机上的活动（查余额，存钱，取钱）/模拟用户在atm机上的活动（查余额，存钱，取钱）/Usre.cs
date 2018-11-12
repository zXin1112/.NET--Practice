using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟用户在atm机上的活动_查余额_存钱_取钱_
{
    class Usre
    {
        //public  Usre ()
        //{
        //    this.name = "";
        //    this.mima = "";
        //    this.zhanghao = "";
        //    this.yue=0;
        //}
        public Usre(string Name, string Mima, string Zhanghao, decimal Yue)
        {
            this.Name = Name;
            this.Mima = Mima;
            this.Zhanghao = Zhanghao;
            this.Yue = Yue;
        }
        /// <summary>
        /// 用户名字
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }//取值
            set
            {
                if (value != "张三")
                    name = value;
                else
                {
                    name = "";
                }//赋值
            }
        }


        /// <summary>
        /// 用户密码
        /// </summary>· 
        private string mima;

        public string Mima
        {
            get { return mima; }
            set { mima = value; }
        }
        /// <summary>
        /// 用户账号
        /// </summary>
        private string zhanghao;

        public string Zhanghao
        {
            get { return zhanghao; }
            set { zhanghao = value; }
        }
        /// <summary>
        /// 用户余额
        /// </summary>
        private decimal yue;

        public decimal Yue
        {
            get { return yue; }
            set { yue = value; }
        }
        /// <summary>
        /// 这个方法的功能是查询余额
        /// </summary>
        public void chayue()
        {
            Console.WriteLine("尊敬的用户{0}你的余额是{1}，请按回车返回", this.name, this.yue);
        }
        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="money">存的钱数</param>
        /// <param name="atm">atm机</param>
        public void cunqian(decimal money, ATM atm)
        {
            Console.WriteLine("请输入您要存储的金额");
            money = Convert.ToDecimal(Console.ReadLine());
            this.yue += money;
            atm.Zongyue += money;
            Console.WriteLine("尊敬的用户{0},您存储了{1}元，您现在的金额为{2}元", this.name, money, this.yue);

        }
        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="atm">atm机</param>
        /// <param name="money"></param>
        public void qvqian(ATM atm, decimal money)
        {
            Console.WriteLine("请输入您要取出的金额");
            money = Convert.ToDecimal(Console.ReadLine());
            if (money > atm.Zongyue)
            {
                Console.WriteLine("ATM机内的金额不足");
            }
            else if (this.yue < money)
            {
                Console.WriteLine("您账户的余额不足");
            }
            else
            {
                this.yue -= money;
                atm.Zongyue -= money;
                Console.WriteLine("尊敬的用户{0}，取钱成功，您现在的余额为{1}", this.name, this.yue);
            }

        }

        public bool Denglu(string ming, string mi, out string msg)
        {
            if (ming == "123456" && mi == "666")
            {
                msg = "登录成功";
                return true;
            }
            else if (ming == "123456")
            {
                msg = "密码错误";
                return false;
            }
            else if (mi == "666")//用户名错误
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "用户名密码错误";
                return false;
            }
        }
    }
}
