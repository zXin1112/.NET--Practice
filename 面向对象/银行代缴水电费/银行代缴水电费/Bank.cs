using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行代缴水电费
{
    class Bank
    {
        public Bank(decimal Shuifei, decimal Dianfei)
        {
            this.Shuifei = Shuifei;
            this.Dianfei = Dianfei;
        }
        private decimal shuifei;//水费

        public decimal Shuifei
        {
            get { return shuifei; }
            set { shuifei = value; }
        }
        private decimal dianfei;//电费

        public decimal Dianfei
        {
            get { return dianfei; }
            set { dianfei = value; }
        }
        /// <summary>
        /// 缴纳水费
        /// </summary>
        /// <param name="user">用户</param>
        public void jiaoshuifei(User user)
        {
            if (this.Shuifei<= user.Shuihaoyue)
            {
                user.Shuihaoyue -=this . Shuifei;
                Console.WriteLine("扣款成功!!!您的水卡号{0}，今缴纳水费{1}元，卡内余额还有{2}元", user.Shihao,this . Shuifei, user.Shuihaoyue);
            }
            else
            {
                Console.WriteLine("缴费失败，请及时充值!");
            }
        }
        /// <summary>
        /// 缴纳电费
        /// </summary>
        /// <param name="user">用户</param>
        public void jiaodianfei(User user)
        {
            if (this.Dianfei <= user.Dianhaoyue)
            {
                user.Dianhaoyue -= this.Dianfei;
                Console.WriteLine("扣款成功!!!您的电卡号{0}，今缴纳电费{1}元，卡内余额还有{2}元", user.Dianhao, this.Dianfei, user.Dianhaoyue);
            }
            else
            {
                Console.WriteLine("缴费失败，请及时充值！");
            }
        }
        /// <summary>
        /// 水卡充值
        /// </summary>
        /// <param name="money">要充值的金额</param>
        /// <param name="user">用户</param>
        public void shuikachongzhi(decimal money, User user)
        {
            user.Shuihaoyue += money;
            Console.WriteLine("充值成功!,您的余额还有{0}元", user.Shuihaoyue);
        }
        /// <summary>
        /// 电卡充值
        /// </summary>
        /// <param name="money">充值金额</param>
        /// <param name="user">用户</param>
        public void diankayuechongzhi(decimal money, User user)
        {
            user.Dianhaoyue += money;
            Console.WriteLine("充值成功!,您的余额还有{0}元", user.Dianhaoyue);
        }
    }
}
