using Fridend_Book.Data;
using Fridend_Book.Service;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Wenjiancaozuo;

namespace Fridend_Book
{
    public partial class FRF_Friengs : Form
    {
        public FRF_Friengs()
        {
            InitializeComponent();
        }
    
        private void FRF_Friengs_Load(object sender, EventArgs e)
        {

            
            if (!Directory .Exists (Application .StartupPath + @"\FriendsBook"))//directory.Exists()用于查询括号内的路径是否存在
            {
                 Directory.CreateDirectory(  Application .StartupPath + @"\FriendsBook");//“@”使“\”这个符号没有特殊语义
            }//Application .StartupPath用于获取当前路径
            FileStream fs = null;
            try
            {
                fs = new FileStream("Firlend.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(BindingList<Friend>));
                Service1.Friends = (BindingList<Friend>)xs.Deserialize(fs);
            }
            catch { }
            finally { if (fs != null) fs.Dispose(); }
          
           this.DGV_Friends.DataSource = Service1.Friends;
        }

        private FarmAddFriend frmADDFriend = null;
        private void BUT_ADD_Click(object sender, EventArgs e)
        {
            if(frmADDFriend ==null || frmADDFriend.IsDisposed )
            {
                frmADDFriend =new FarmAddFriend ();
            }
            frmADDFriend.Show();
        }

        private void BUT_DEL_Click(object sender, EventArgs e)
        {
            if (this.DGV_Friends.SelectedRows.Count == 0) return;
            int index = this.DGV_Friends.SelectedRows[0].Index;
            Service1 service=new Service1 ();
            int a = service.DelFriend(index);
            if (a==1)
            {
                MessageBox.Show("删除朋友成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("删除朋友失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Friends_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("123");
        }

        private void BTNrz_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();

        }

        private void FRF_Friengs_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("Firlend.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(BindingList<Friend>));// typeof  用于获取类型的 System.Type 对象。表达式采用以下形式：System.Type type = typeof(int);
                xs.Serialize(fs, Service1.Friends);
                fs.Close();
            }
            catch (Exception ex) { }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);
            pd.DefaultPageSettings.PaperSize = new PaperSize("A16", 200, 120);
            pd.PrintPage += pd_PrintPage;
            ppdfriend.Document = pd;
            if (ppdfriend .ShowDialog ()==DialogResult .OK )
            {
                try
                {  pd.Print();
                }
                catch
                {
                    MessageBox.Show("打印出错！！");
                }
            }
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (this.DGV_Friends.SelectedRows.Count == 0) return;
            int index = this.DGV_Friends.SelectedRows[0].Index;
            Friend f = Service1.Friends[index];
            Graphics g = e.Graphics;
            string s = String.Format("姓名：{0}",f.XM );//打印什么文字
            Font font = new Font(new FontFamily("宋体"), 14, FontStyle.Regular);//打印文字字体大小等的设置
            g.DrawString(s, font, Brushes.Black, new PointF(2, 2));//打印文字
            //画直线
            Pen pen = new Pen(Color.Black, 1);//设置画笔
            g .DrawLine (pen ,new Point(0, 20), new Point(200, 20));//画线，设置两个点的坐标，两点连成一条直线

            //画图
            try
            {
                 Image image = Image.FromFile(Application .StartupPath + @"\FriendsBook\" + f.Photo);
                 g.DrawImage(image, 150, 0, 50, 50);
            }
            catch { }
        }

        private void BTNxiugai_Click(object sender, EventArgs e)
        {
            if (this.DGV_Friends.SelectedRows.Count == 0) return;
            int index = this.DGV_Friends.SelectedRows[0].Index;

            FrmModify frmmodify = new FrmModify(index );
            frmmodify.Show();

            frmmodify.FormClosing += frmmodify_FormClosing;//在窗体FrmModily关闭时，要执行的活动
        }

        void frmmodify_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DGV_Friends.DataSource = Service1.Friends;//强制显示控件重新加载集合
        } 
    }
}
