# 接口

## 什么是接口

> 接口是指定一组函数成员 而不实现他们 的**引用类型**。所以只能类和结构来实现接口。
> ### 例
>
	interface IMyInterface//声明接口
    {
      //成员
        string SValue { get; set; }
        void PrintOut();
    }
	class MyClass : IMyInterface//实现接口
    {
        public string SValue { get; set; }//实现属性
        public void PrintOut()//实现方法
        {
            Console.WriteLine("string {0}", SValue);
        }
    }
	 class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { SValue = "object" };//创建对象
            myClass.PrintOut();//使用实现的方法
	    }
	}
> ### 接口使用的步骤
> * 声明接口
> * 实现接口
> * 创建对象，使用方法函数

## 声明接口
> ### 注意事项
> * 接口声明不能包含以下成员
>   + 数据成员
>   + 静态成员
> * 接口声明只能包含如下类型的非静态成员函数的声明
>   + 方法
>   + 属性
>   + 事件
>   + 索引器
> * 这些函数成员的声明不能包含任何实现代码，而在每一个成员声明的主题后必须使用分号
> * 按照惯例，接口名称必须从大写的I开始
> * 接口声明可以分隔成分部接口声明
> * 接口声明可以有任何的访问修饰符 `public`，`protected`，`internal`或`private`
> * 接口成员是隐式`public`，不允许有任何访问修饰符，包括`public`

> ### 例
>
		interface IMyInterface 
		{
			void PrintOut();
		}
![](https://i.imgur.com/vEZNLSd.png)


## 实现接口

> ### 注意事项
> * 在基类列表中包括接口名称
> * 为每一个成员提供实现
> ### 例
>
	class MyClass: IMyInterface
	{
		int DoSuff (int nVar,long lVar)
		{....}//实现代码
	}
> * 如果类实现了接口，他必须实现接口的所有成员
> * 如果基类继承并实现了接口，基类列表中的基类名称必须放在所有接口之前（只能有一个基类）
> ![](https://i.imgur.com/7k7nOIA.png)

## 接口是引用类型
> 接口不仅仅是类或结构要实现的成员列表，他是引用类型
> 
> 但不能直接通过类的对象的成员访问接口，可以通过将类对象的引用强制转换为接口类型来获取接口的引用
> 
> 如下图所示
> 
> ![](https://i.imgur.com/PMgmvwo.png)
> ### 备注
> * 也可使用`as`运算符转换引用
>   + 若类实现接口，表达式返回指向接口的引用。
>   + 若没实现，表达式返回`null`而不是抛异常（强制转换接口为实现时，会抛出异常）
>   
> ### 例
>
	interface IMyInterface//声明接口
    {
      //成员
        string SValue { get; set; }
        void PrintOut();
    }
	class MyClass : IMyInterface//实现接口
    {
        public string SValue { get; set; }//实现属性
        public void PrintOut()//实现方法
        {
            Console.WriteLine("string {0}", SValue);
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
 			//IMyInterface myInterface = (IMyInterface)myClass1;强制转换的方式
            IMyInterface myInterface = myClass1 as IMyInterface;//使用as运算符
            //两种方式效果相同
            if (myInterface != null)
            {
                myInterface.PrintOut();
            }
        }
    }

## 实现多个接口

> 类和结构可以实现任意数量的接口，所有实现的接口都必须列在基类列表中，并以逗号分隔。
> ### 例
> 
	interface IDataStore//接口声明
    {
        //成员
        void SetData(int x);
    }
	interface IDataRetrieve//接口声明
    {
        //成员
        int GetData();
    }
	class MyData : IDataRetrieve, IDataStore//实现接口
    {
        int Mem1;
        public int GetData()//实现方法
        {
            return Mem1;
        }
        public void SetData(int x)//实现方法
        {
            Mem1 = x;
        }
	}

## 实现重复成员的接口

> 如果一个类实现了多个接口，并且其中一些接口具有相同签名和返回类型的成员，那么类可以实现单个成员来满足所有包含重复成员的接口
> ### 如下图所示
> ![](https://i.imgur.com/Etj4N4F.png)

## 派生成员作为实现
> 实现接口的类可以从他的基类继承实现代码
> ### 例
>
	interface IIfc1//接口
    {
        //成员
        void PrintOut(string s);
    }
 	class MyBaseClass : IIfc1//基类实现接口
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("String: {0}", s);
        }
    }
	//派生类
    class Derived : MyBaseClass//继承基类
    {
    }
	class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();//派生类对象
            derived.PrintOut("object");//调用实现方法
            Console.ReadKey();
        }
    }

## 显式接口成员实现
> 单个类可以实现多个接口需要的所有成员，也可以为每一个接口分离实现
> ### 例
> 
	interface IIfc1//声明接口
    {
        //成员
        void PrintOut(string s);
    }
	interface IIfc2//声明接口
    {
        //成员
        void PrintOut(string s);
    }
    class MyClass:IIfc1,IIfc2//实现接口
    {
         void IIfc1.PrintOut(string s)//显式实现
        {
            Console.WriteLine("IIfc1:{0}", s);
        }
        void IIfc2.PrintOut(string s)//显式实现
        {
            Console.WriteLine("IIfc2:{0}", s);
        }
        public void Method(string s)
        {
            ((IIfc1)this).PrintOut(s);//实现类内部访问显式实现成员
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();//创建对象
            myClass.Method("myClass");//访问显式接口成员
            IIfc1 ifc1 = myClass as IIfc1;//获取iifc1的引用
            IIfc2 ifc2 = myClass as IIfc2;//获取iifc2的引用
            ifc1.PrintOut("interface1");
            ifc2.PrintOut("interface2");//调用显式实现方法
            Console.ReadKey();
        }
    }

> ### 注意事项
> * 实现时，使用限定接口名称来声明
> * 显式接口成员实现只可以通过指向接口的引用来访问，其他的类成员都不可以直接访问他们，即使是实现接口类的成员也不可以直接访问显式实现。
> * 可以强制转换当前对象的引用（`this`）为接口类型的引用，并使用这个指向接口的引用来调用显示实现


## 接口继承接口
> 接口本身也可以从一个或多个接口继承
> ### 注意事项
> * 要指定某个接口继承其它接口，应在接口声明中把基接口，以逗号分隔的列表形式放在接口名称的冒号之后
> * 与类不同，类的基类列表只能有一个类名，而接口可以有任意数量的接口
>   + 结果接口中包含他声明的所有接口和所有基接口
> ### 例
>
	interface IDataRetrieve//声明接口
    {
        //成员
        int GetData();      
    }
	interface IDataStore//声明接口
    {
        //成员
        void SetData(int x);        
    }
	interface IData: IDataRetrieve,IDataStore//接口继承接口
    {    }
	class MyData : IData//实现接口
    {
        int Mem;
        public void SetData(int x)//实现方法
        {
            Mem = x;
        }
        public int  GetData()//实现方法
        {
            return Mem;
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            MyData myData = new MyData();//创建对象
            myData.SetData(5);
            Console.WriteLine("Number: {0}",myData.GetData());//实现方法
            Console.ReadKey();
        }
    }

## 不同类实现同一接口
> ### 示例
>
	interface ILiveBirth//声明接口
    {
        //成员
        string BabyCalled();
    }
	class Animal//基类
    {
    }
	class Bird: Animal//继承基类
    {
    }
	class Cat : Animal, ILiveBirth//继承基类，实现接口
    {
        public string BabyCalled()
        {
            return "Kitten";
        }
    }
	class Dog : Animal, ILiveBirth//继承基类，实现接口
    {
        public string BabyCalled()
        {
            return "Puppy";
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> {
                new Cat(),
                new Bird(),
                new Dog()
            };//将各个动物类添加到泛型集合中
            foreach (Animal item in animals)//遍历
            {
                ILiveBirth liveBirth = item as ILiveBirth;//转接口引用
                if (liveBirth != null)//若实现接口
                    Console.WriteLine("this is {0}", liveBirth.BabyCalled());//执行实现方法
            }
            Console.ReadKey();
        }
    }