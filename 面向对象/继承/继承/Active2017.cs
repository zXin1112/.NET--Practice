using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Active2017 : Active
    {
        private int ziyuan3;

        public int Ziyuan3
        {
            get { return ziyuan3; }
            set { ziyuan3 = value; }
        }
        public void Account3()
        {

            Console.WriteLine("聚餐");
        }
        public override void Asd()//override对应父类中的 virtual可更改父类中的方法
        {
            base.Asd();//base 关键字用于从派生类中访问基类的成员：

            //调用基类上已被其他方法重写的方法。

            //指定创建派生类实例时应调用的基类构造函数。

            //基类访问只能在构造函数、实例方法或实例属性访问器中进行。

            //从静态方法中使用 base 关键字是错误的。


            Console.WriteLine("改动");
        }
    }
}
