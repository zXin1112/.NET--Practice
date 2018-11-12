using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianxi.DATA
{
    class Commodity
    {
        public Commodity ()
        {
            this._Name = "";
            this._Origin = "";
            this ._Price=0;
            this._Quantity = 0;
        }
        private string _Name;//商品名

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _Quantity;//数量

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        private decimal _Price;//价格

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        private string _Origin;//产地

        public string Origin
        {
            get { return _Origin; }
            set { _Origin = value; }
        }
    }
}
