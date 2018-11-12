using Lianxi.DATA;
using Lianxi.SERVRCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lianxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            Commodity c = new Commodity();
            c.Name = TXTNAME.Text;
            c.Origin = TXTCHANDI.Text;
            c.Price = Convert .ToDecimal ( TXTDANJIA.Text);
            c.Quantity =Convert .ToInt32 ( TXTSHULIANG.Text );   
            Add a = new Add();
            a.add(c);
            MessageBox.Show("添加成功");
            this.Close();
        }
    }
}
