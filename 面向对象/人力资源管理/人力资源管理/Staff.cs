using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 人力资源管理
{
    class Staff
    {//试创建一个员工类，包含员工号、姓名、性别、身份证号、月工资5个属性；
        public Staff ()
        {

        }
        private string _GH;//员工号

        public string GH
        {
            get { return _GH; }
            set { _GH = value; }
        }




        private string _Name;//姓名

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }



        private string _Sex;//性别

        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }




        private string _ID;//身份证号

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }




        private string _Wages;//工资

        public string Wages
        {
            get { return _Wages; }
            set { _Wages = value; }
        }

       


    }
}
