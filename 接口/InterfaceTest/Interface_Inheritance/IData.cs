using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    interface IData: IDataRetrieve,IDataStore//接口继承接口
    {
        
    }
}
