using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gongzi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNtianjia_Click(object sender, EventArgs e)
        {

        }
        Gongzi g = new Gongzi();
        private void BTNtianjia_Click_1(object sender, EventArgs e)
        {
            Service ser = new Service();
           
            g.Riqi = Convert.ToString(DateTime.Now);
            switch (CMBxiangmu.Text)//日期、工资、、、、、。
            {
                case "工资":
                    g.Gong = Convert.ToDecimal(TXTjine.Text);
                   
                    textBox1.Text += g.Riqi+"工资";
                    break;
                case "房租":
                    g.Fangzu = Convert.ToDecimal(TXTjine.Text);
                    textBox1.Text += g.Riqi + "房租";

                    break;
                case "水电":
                    g.Shuidian =Convert .ToDecimal (TXTjine .Text );
                    textBox1.Text += g.Riqi + "水电费";

                    break ;
                case "饭费":
                    g.Fanfei = Convert.ToDecimal(TXTjine.Text);
                    textBox1.Text += g.Riqi + "饭费";

                    break;
                case "电话费":
                    g.Dianhua = Convert.ToDecimal(TXTjine.Text);
                    textBox1.Text += g.Riqi + "电话费";

                    break;
                case "其它开销":
                    g.Qita = Convert.ToDecimal(TXTjine.Text);
                    textBox1.Text += g.Riqi + "其它开销";
                    
                    break;

            }
            textBox1.Text += TXTjine.Text + "\r\n";
          int x=  ser.Add(g);
           
          if (x == 1)
          {
              MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
              MessageBox.Show("添加失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          TXTjine.Text="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            string[] xiangmu = (string[])Service.Gongzis["项目"];
            CMBxiangmu.Items.AddRange(xiangmu);
        }

        private void BTNzongji_Click(object sender, EventArgs e)
        {
            
             decimal a = g.Gong + g.Fanfei + g.Dianhua + g.Fangzu + g.Qita + g.Shuidian;
             MessageBox.Show("总计剩余:"+a  );
        }
           
    }
}
