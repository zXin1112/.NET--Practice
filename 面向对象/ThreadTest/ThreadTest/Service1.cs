using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    class Service1
    {
        public void BigComputer()
        {
            decimal i = 0;
            while (true)
            {
                i++;
                if (i == 1000000000) i = 0;
            }
        }

        private Control _ShowControl;

        public void ShowProgress(object obj)
        {
            this._ShowControl = (Control)obj;
           

            int i = 0;
            while (true)
            {
                i++;
                ShowValueHandler svh = new ShowValueHandler(ShowValue);
                this._ShowControl.Invoke(svh, new object[] { i });//将赋值显示放到主线程
                Thread.Sleep(1);
                if (i == 10000) i = 0;
            }
        }

        public delegate void ShowValueHandler(int i);

        private void ShowValue(int i)
        {
            ProgressBar prg = (ProgressBar)this._ShowControl;
            prg.Value = i;
        }

    }
}
