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
    public partial class Form2 : Form
    {
        public delegate void DelTest(string str);
        public Form2(DelTest del)
        {
            InitializeComponent();
            _del = del;
        }
        //在窗体2中写一个返回值，形参（即函数签名）一样的构造函数，窗体是一个类，在窗体的构造函数中利用构造函数定义的值将窗体1的方法接收过来
        public DelTest _del;
      
        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text);
        }
 }
}
