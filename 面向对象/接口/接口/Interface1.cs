using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface Interface1//接口
    {
        string read1c     //接口  定义属性
        { get; set; }
        int wefwe { get; set; }
        void A();//定义方法

        void B(string DD, int FF);

    }//接口只包含 方法、 属性、 事件或 索引器的签名。 实现接口的类或结构必须实现接口定义中指定的接口成员
}
