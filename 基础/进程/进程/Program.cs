using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //打开桌面上的一个文件或者应用程序
            ProcessStartInfo psi = new ProcessStartInfo(@"");
            //指定启动进程时使用的应用程序或文件名
            Process ps = new Process();
            ps.StartInfo = psi; 
            ps.Start();
            Console.ReadKey();
           
        }
    }
}