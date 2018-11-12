using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        //窗体1中有方法，窗体2中有数值，在创建窗体2的新对象时将方法传递给窗体2
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Showmsg );
            form2.Show();
        }
        void Showmsg(string str)
        {
            label1.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
