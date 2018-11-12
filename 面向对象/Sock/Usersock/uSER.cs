using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usersock
{
    public partial class uSER : Form
    {
        public uSER()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void btnSTART_Click(object sender, EventArgs e)
        {
            //创建负责通信的socket
            socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//指定ip格式，指定类型的流，TCP协议
            IPAddress ip = IPAddress.Parse(txtIP.Text);//将 IP 地址字符串转换为 IPAddress 实例。
            IPEndPoint pion = new IPEndPoint(ip, Convert.ToInt32(txtDUAN.Text));// IPEndPoint(IPAddress, Int32)用指定的地址和端口号初始化 IPEndPoint 类的新实例。
            socketSend.Connect(pion);//Connect(EndPoint)建立与远程主机的连接。
            MSBSHOW("连接成功");
            Thread th = new Thread(Jieshou);
            th.IsBackground = true;
            th.Start();
        }
        void MSBSHOW(string str)
        {
            txtLOG.Invoke(new Action(() => { txtLOG.AppendText(str + "\r\n"); }));


        }
        /// <summary>
        /// 客户端发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFASONG_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtSend.Text.Trim();//Trim()从当前 String 对象移除所有前导空白字符和尾部空白字符。
                byte[] buffersend = Encoding.UTF8.GetBytes(str);//将输入的字符转变成字节
                socketSend.Send(buffersend);//将数据发送到连接的 Socket。
                txtSend.Text = "";
            }
            catch
            {


            }

        }
        void Jieshou()
        {
            try
            {
                while (true)
                {
                    byte[] jiebuffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(jiebuffer);
                    if (r == 0) { MSBSHOW(socketSend.RemoteEndPoint + "已下线"); break; }
                    string str = Encoding.UTF8.GetString(jiebuffer, 0, r);
                    MSBSHOW(socketSend.RemoteEndPoint + ";" + str);

                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
