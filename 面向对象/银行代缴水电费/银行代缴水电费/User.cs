using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行代缴水电费
{
    class User
    {
        public User(string Name, string Shuihao, string Dianhao, decimal Shuihaoyue, decimal Dianhaoyue)
        {
            this.Name = Name;
            this.Shihao = Shuihao;
            this.Dianhao = Dianhao;
            this.Shuihaoyue = Shuihaoyue;
            this.Dianhaoyue = Dianhaoyue;
        }
        private string name;//名字

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string shihao;//水卡号

        public string Shihao
        {
            get { return shihao; }
            set { shihao = value; }
        }
        private string dianhao;//电卡号

        public string Dianhao
        {
            get { return dianhao; }
            set { dianhao = value; }
        }
        private decimal shuihaoyue;//水卡余额

        public decimal Shuihaoyue
        {
            get { return shuihaoyue; }
            set { shuihaoyue = value; }
        }
        private decimal dianhaoyue;//电卡余额

        public decimal Dianhaoyue
        {
            get { return dianhaoyue; }
            set { dianhaoyue = value; }
        }
    }
}
