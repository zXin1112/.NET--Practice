using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gongzi
{
    class Gongzi
    {

        private string _Riqi;

        public string Riqi
        {
            get { return _Riqi; }
            set { _Riqi = value; }
        }
        private decimal _Gong;

        public decimal Gong
        {
            get { return _Gong; }
           set { _Gong = value; }
        }
        private decimal _Fangzu;    

        public decimal Fangzu
        {
            get { return _Fangzu; }
            set { _Fangzu = value*(-1); }
        }
        private decimal _Shuidian;

        public decimal Shuidian
        {
            get { return _Shuidian; }
            set { _Shuidian = value * (-1); }
        }
        private decimal _Fanfei;

        public decimal Fanfei
        {
            get { return _Fanfei; }
            set { _Fanfei = value * (-1); }
        }
        private decimal _Dianhua;

        public decimal Dianhua
        {
            get { return _Dianhua; }
            set { _Dianhua = value * (-1); }
        }
        private decimal _Qita;

        public decimal Qita
        {
            get { return _Qita; }
            set { _Qita = value * (-1); }
        }
        public Gongzi ()
        {
            this._Riqi = "";
            this._Gong = 0;
            this._Fangzu = 0;
            this._Shuidian = 0;
            this._Fanfei = 0;
            this._Dianhua = 0;
            this._Qita = 0;
        }
    }
}
