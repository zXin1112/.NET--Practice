using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 人力资源管理
{
    class Function
    {
        //试创建一个管理员工信息的功能类，包含下列方法：
        //添加员工；
        //根据员工号删除员工；
        //修改员工信息
        //根据身份证求该员工的月工资；
        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        public void TJ(Staff st)
        {
            Console.Write("姓名：");
             st .Name  = Console.ReadLine();
            Console.Write("工号：");
        st .GH    = Console.ReadLine();
            Console.Write("性别：");
           st .Sex   = Console.ReadLine();
            Console.Write("身份证号：");
           st .ID   = Console.ReadLine();
            Console.Write("工资：");
          st .Wages    = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("添加成功！您输入的员工信息为：");
            Console.WriteLine(@"姓名：{0}
工号：{1}
性别：{2}
身份证号：{3}
工资：{4}
按任意键退出",st .Name ,st .GH ,st .Sex ,st .ID ,st .Wages  );
        }
        #endregion
        #region 删除员工信息
        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="hao"></param>
        public void SC(string hao,Staff st)
        {
            if (hao ==st .GH  )
            {
              st.GH = "";
                st.Name = "";
                st.Sex = "";
               st.ID = "";
               st.Wages = "";
                Console.WriteLine("删除成功！");
            }
            else
            {
                Console.WriteLine("未查询到工号为{0}的员工，删除失败，程序退出",hao );
            }
        }
        #endregion
        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        public void XG(Staff st)
        {
            Console.WriteLine("请重新输入以下信息：");
            Console.Write("姓名：");
            st.Name = Console.ReadLine();
            Console.Write("工号：");
            st.GH = Console.ReadLine();
            Console.Write("性别：");
            st.Sex = Console.ReadLine();
            Console.Write("身份证号：");
            st.ID = Console.ReadLine();
            Console.Write("工资：");
            st.Wages = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("添加成功！您输入的员工信息为：");
            Console.WriteLine(@"姓名：{0}
工号：{1}
性别：{2}
身份证号：{3}
工资：{4}
按任意键退出", st.Name, st.GH, st.Sex, st.ID, st.Wages);
        }
        #endregion
        #region 求工资
        /// <summary>
        /// 求工资
        /// </summary>
        /// <param name="id"></param>
        public void GZ(string id,Staff st)
        {
            if (id == st.ID)
                Console.WriteLine("身份证号{0} 的月工资为{1]", id, st.Wages);
            else
                Console.WriteLine("未查找到身份证号{0}员工的信息", st.ID);
        }
        #endregion
    }
}
