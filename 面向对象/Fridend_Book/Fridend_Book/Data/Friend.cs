using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridend_Book.Data
{
   public  class Friend
    {
        private string _XM;//姓名

        public string XM
        {
            get { return _XM; }
            set { _XM = value; }
        }
        private string _XB;//性别

        public string XB
        {
            get { return _XB; }
            set { _XB = value; }
        }
        private string _SJH;//手机号

        public string SJH
        {
            get { return _SJH; }
            set { _SJH = value; }
        }
        private string _DZ;//地址

        public string DZ
        {
            get { return _DZ; }
            set { _DZ = value; }
        }
        private string _Email;//邮箱

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _JG;//籍贯

        public string JG
        {
            get { return _JG; }
            set { _JG = value; }
        }
        private string _QQ;

        public string QQ
        {
            get { return _QQ; }
            set { _QQ = value; }
        }
        private string _WX;//微信

        public string WX
        {
            get { return _WX; }
            set { _WX = value; }
        }
        private string _Photo;//头像

        public string Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }
        private string _PY;//评语

        public string PY
        {
            get { return _PY; }
            set { _PY = value; }
        }
        private string _Birthday;
 
     public string Birthday
    {
        get { return _Birthday; }
         set { _Birthday = value; }
      }
      public int Age
        {
            get {
                TimeSpan  tsage=DateTime .Now -Convert .ToDateTime (_Birthday );
                return tsage .Days /365;
                }
      }
        
   public Friend()
        {
            this._XM = "";
            this._XB = "";
            this._SJH = "";
            this._DZ = "";
            this._Email = "";
            this._JG = "";
            this._QQ = "";
            this._WX = "";
            this._Photo = "";
            this._PY = "";
            this._Birthday = "";
        }
          
            
        }
  }

