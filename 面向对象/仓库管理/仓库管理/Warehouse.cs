using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理
{
    class Warehouse
    {
        //试创建一个仓库类（假设一个仓库只存储一种货物），创建仓库号，仓库地址，剩余面积，货物名称 4个属性；
        //    创建4属性的构造函数；
        //      创建一个入库方法，根据入库货物面积重新计算剩余面积；
        //      创建一个显示仓库信息的方法。
        public Warehouse()
        {

        }
        public Warehouse(string hao, string dz, double mianji, string name)
        {
            this._Hao = hao;
            this._Dz = dz;
            this._MianJi=mianji ;
           this._Name=name ;
        }
        private string _Hao;

        public string Hao
        {
            get { return _Hao; }
            set { _Hao = value; }
        }
        private string _Dz;

        public string Dz
        {
            get { return _Dz; }
            set { _Dz = value; }
        }
        private double _MianJi;

        public double MianJi
        {
            get { return _MianJi; }
            set { _MianJi = value; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public void RK(double rk)
        {
            _MianJi = _MianJi - rk;
            Console.WriteLine("货物入库后剩余面积为{0}", _MianJi);
            Console.ReadKey();
        }
        public virtual  void CX()
        {
            Console.WriteLine(@"仓库号:{0}
            仓库地址:{1}
            剩余面积:{2}
            货物名称:{3}", _Hao, _Dz, _MianJi, _Name);
            
        }
       
    }
}
