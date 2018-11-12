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

namespace Sock
{
    public partial class FUWU : Form
    {
        public FUWU()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Socket socketwatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp );//创建一个负责监听的ip跟端口号的socket（ip，套接字类型，传输协议）
            //AddressFamily 指定 Socket 类的实例可以使用的寻址方案。
            IPAddress ip = IPAddress.Any;//监听到的ip地址
            //IPAddress.Any 提供一个 IP 地址，指示服务器应侦听所有网络接口上的客户端活动。 此字段为只读。
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtDUAN.Text));
            //创建端口号对象
            socketwatch.Bind(point);
            //绑定bind
            MessageBox.Show("监听成功");
            socketwatch.Listen(10);//设置监听队列
            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketwatch );//括号里listen需要的参数
            

        }
        Socket soketSend;//负责通信的 Socket。
        /// <summary>
        /// 等待客户端链接
        /// </summary>
        void Listen(object o)
        {
            try
            {
                Socket socketwatch = o as Socket;
                while (true)
                {
         soketSend = socketwatch.Accept();//Accept()为新建连接创建新的负责通信 Socket。
                    MSBSHOW(soketSend.RemoteEndPoint.ToString() + ":" + "链接成功");//RemoteEndPoint是在调用 Accept 或 Connect 之后设置的。 可以调用 IPEndPoint.Address 方法来检索远程 IPAddress，调用 IPEndPoint.Port 方法来检索远程端口号。
                    //获取到链接过来的ip和端口号

                    Thread th = new Thread(Jieashou);//开启新线程，不停地接受发送的消息
                    th.IsBackground = true;
                    th.Start(soketSend);

                }
            }
            catch 
            {
                             
            }
           
            
        }


        void MSBSHOW(string str)
        {
            txtlog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="o"></param>
        void Jieashou(object o)
        {
            try
            {
                Socket soketSend = o as Socket;
                while (true)
                {
                    //连接成功后应开始接受客户端的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];//1024*124*2定义的接受字节的容量
                    int r = soketSend.Receive(buffer);//接收来自绑定的 Socket 的数据。接受的是数组，方法返回接受的字节数
                    string str = Encoding.UTF8.GetString(buffer, 0, r);//Encoding.UTF8.GetString将字节转变成字符,也可将字符转换为字节，
                    if (r == 0) { MSBSHOW(soketSend.RemoteEndPoint + "链接断开"); break; }//若r=0则接收到的字节数为零，所以对方客户端已下线
                    //此处接收到的是字节，应转换成字符显示出来，所以用encoding
                    MSBSHOW(soketSend.RemoteEndPoint + ";" + str);
                    //RemoteEndPoint 得到远程的ip、端口号
                }
            }
            catch
            { }
                
             
         
        }
        /// <summary>
        /// 服务器发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFa_Click(object sender, EventArgs e)
        {
            try
            {
                  string str = txtSend.Text.Trim();
            byte[] sendbuffer = Encoding.UTF8.GetBytes(str);
            soketSend.Send(sendbuffer );
            txtSend.Text = "";
            }
            catch 
            {

                MSBSHOW(soketSend.RemoteEndPoint + "链接断开");
            }
          
        }
    }
}
