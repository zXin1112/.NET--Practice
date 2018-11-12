using Fridend_Book.Data;
using Fridend_Book.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fridend_Book
{
    public partial class FrmModify : Form
    {
        public FrmModify()
        {
            InitializeComponent();
        }
        private int _Index;

        public FrmModify(int index)
        {
            InitializeComponent();
            this._Index = index;
        }

        private void FrmModify_Load(object sender, EventArgs e)
        {
            Friend f = Service1.Friends[_Index];
            this.txtXM.Text = f.XM;
            this.comboBoxXB.Text = f.XB;
            this.dtpBirthday.Text = f.Birthday;
            this.txtSJH.Text = f.SJH;
            this.txtEMAIL.Text = f.Email;
            this.txtPY.Text = f.PY;
            this.txtQQ.Text = f.QQ;
            this.txtWX.Text = f.WX;
            this.txtDZ.Text = f.DZ;
            this.PicHead.ImageLocation = Application.StartupPath + @"\FriendsBook\" + f.Photo;
            string[] a = f.JG.Split(new char[] { ' ' });
            if (a.Length == 3)
            {
                this.cmbProvince.Text = a[0];
                this.cmbCity.Text = a[1];
                this.cmbdiqu.Text = a[2];
            }
            String[] province = (String[])Service1.JGData["省份"];
            cmbProvince.Items.AddRange(province);
        }

        private void BTNxiu_Click(object sender, EventArgs e)
        {
            Friend f = Service1.Friends[_Index];
            f.XM = this.txtXM.Text;
            f.XB = this.comboBoxXB.Text;
            f.SJH = this.txtSJH.Text;
            f.DZ = this.txtDZ.Text;
            f.Email = this.txtEMAIL.Text;
            f.JG = this.cmbProvince.Text + " " + this.cmbCity.Text + " " + this.cmbdiqu.Text;
            f.QQ = this.txtQQ.Text;
            f.WX = this.txtWX.Text;
            if (!String.IsNullOrEmpty(this.PicHead.ImageLocation))
            {
                int c = this.PicHead.ImageLocation.LastIndexOf(@"\");
                f.Photo = this.PicHead.ImageLocation.Substring(c + 1);
            }

            f.PY = this.txtPY.Text;
            f.Birthday = this.dtpBirthday.Value.ToString("yyyy-MM-dd");
            MessageBox.Show("修改成功！");
            this.Close();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();
            cmbdiqu.Items.Clear();

            string key = cmbProvince.Text;
            String[] city = (String[])Service1.JGData[key];
            cmbCity.Items.AddRange(city);
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdiqu.Items.Clear();

            string key = cmbCity.Text;
            String[] diqu = (String[])Service1.JGData[key];
            cmbdiqu.Items.AddRange(diqu);
        }

        private void PicHead_Click(object sender, EventArgs e)
        {
            if (this.OFDphoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string source = this.OFDphoto.FileName;
                    string dest = Application.StartupPath + @"\FriendsBook\" + this.OFDphoto.SafeFileName;
                    File.Copy(source, dest, true);
                    PicHead.ImageLocation = dest;
                }
                catch { }
            }
        }
    }
}
