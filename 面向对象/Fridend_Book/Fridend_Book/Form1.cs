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

namespace Wenjiancaozuo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw = null ;
            try
            {
                //FileStream fs = new FileStream(Application.StartupPath  + @"\Sart.log", FileMode.OpenOrCreate, FileAccess.ReadWrite );
                sw = new StreamWriter(Application.StartupPath + @"\Sart.log", true); //在当前程序运行目录下创建一个名为Sarrt.log的文件，TRUE表示可在此文件下继续写入                                   
                //DateTime dt=DateTime .Now ;
                //string a = dt.ToString("yyyy-MM-dd hh:mm:ss");//将时间转变为自己所需要的格式
                sw.WriteLine("启动时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));//写入,将时间转变为自己所需要的格式
                sw.Close();//清除收回
                
                //fs.Close();
            }
            catch (Exception ex)
                 {
                     
            
            }
               

            finally {
                if (sw !=null )
                sw.Dispose();
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        { StreamReader sr=null ;
        try
        {
            sr = new StreamReader(Application.StartupPath + @"\Sart.log");//对当前程序运行的目录下中的Sart.log 文件的操作
            string s = sr.ReadToEnd();//读取刚刚定位的文件，将读取的内容给变量s
            TXTshow.Text = s;//在给控件txt显示文本信息
            sr.Close();
        }
        catch (Exception ex) { }//表示在应用程序执行过程中发生的错误。
        finally
        {
            if( sr !=null )
         sr.Dispose();
        }
          
        }
    }
}
