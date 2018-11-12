using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理
{
    class Danderous : Warehouse
    {
        //试创建一个危险品仓库类，比仓库类多危险品等级属性；
        //     创建5属性的构造函数；需创建显示危险品仓库信息的方法。
          public Danderous ()
        {

        }
        public Danderous(string hao, string dz, double mianji, string name, string dengji)
            : base(hao, dz, mianji, name)
        {
            this._Dengji = dengji;
        }
      
        private string _Dengji;

        public string Dengji
        {
            get { return _Dengji; }
            set { _Dengji = value; }
        }
        public override void CX()
        {
                base.CX();
                Console.WriteLine("危险等级为：{0}", Dengji);
                Console.ReadKey();
        }
    }
}
