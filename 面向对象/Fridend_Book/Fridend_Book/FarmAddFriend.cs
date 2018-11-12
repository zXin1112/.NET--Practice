using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fridend_Book.Service;
using Fridend_Book.Data;
using System.IO;

namespace Fridend_Book
{
    public partial class FarmAddFriend : Form
    {
        public FarmAddFriend()
        {
            InitializeComponent();
        }

        private void btnENTER_Click(object sender, EventArgs e)
        {
            Friend f = new Friend();
            f.XM = txtXM.Text;
            f.XB = comboBoxXB.Text;
            f.SJH = txtSJH.Text;
            f.DZ = txtDZ.Text;
            f.Email = txtEMAIL.Text;
            f.JG = cmbProvince.Text +" "+ cmbCity.Text +" "+ cmbdiqu.Text;
            f.QQ = txtQQ.Text;
            f.WX = txtWX.Text;
            if (!String.IsNullOrEmpty(PicHead.ImageLocation))
            {
                int index = PicHead.ImageLocation.LastIndexOf(@"\");
                f.Photo = PicHead.ImageLocation.Substring(index + 1);
            }

            f.PY = txtPY.Text;
            f.Birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            Service1 service = new Service1();
            int x = service.AddFriend(f);
            if (x == 1)
            {
                MessageBox.Show("添加朋友成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加朋友失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

        private void Btncancle_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确定取消当前操作？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

            }
            this.Close();
        }

        private void FarmAddFriend_Load(object sender, EventArgs e)
        {
            String[] province = (String[])Service1.JGData["省份"];
            cmbProvince.Items.AddRange(province);
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



        private void PicHead_Click_1(object sender, EventArgs e)
        {
            if (ofdHead.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string source = ofdHead.FileName;
                    string dest = Application.StartupPath + @"\FriendsBook\" + ofdHead.SafeFileName;
                    File.Copy(source, dest, true);
                    PicHead.ImageLocation = dest;
                }
                catch { }
            }
            //FileStream   fs = new FileStream(@"c:\test", FileMode.OpenOrCreate, FileAccess.Read);

            //StreamReader sr = new StreamReader(@"c:\tese");
            //string a = sr.ReadToEnd();
            //sr.Close();
            //sr.Dispose();
            //StreamWriter sw = new StreamWriter(@"c:\test", true);
            //sw.WriteLine("dcdasef");
            //sw.Close();
            //sw.Dispose();

        }
    }
}
