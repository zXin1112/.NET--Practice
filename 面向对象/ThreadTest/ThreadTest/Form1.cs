using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();
            service.BigComputer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();

            ThreadStart ts = new ThreadStart(service.BigComputer);//委托

            Thread thread = new Thread(ts);//多线程
            thread.Start();//准备就绪，在括号内放方法参数
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (true)
            {
                i++;
                prgTest.Value = i;
                Thread.Sleep(10);
                if (i == 10000) i = 0;
            }
        }

        private Thread thread = null;

        private void button4_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();
            ParameterizedThreadStart pts = new ParameterizedThreadStart(service.ShowProgress);//委托

            thread = new Thread(pts);//多线程

           thread.IsBackground = true;//后台线程：不管线程是否结束，只要所有的前台线程都退出（包括正常退出和异常退出）后，进程就会自动终止。


            thread.Start(this.prgTest);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread.Abort();
            prgTest.Value = 10000;
        }
    }
}
