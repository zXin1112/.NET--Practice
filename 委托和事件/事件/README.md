# 事件

## 发布者和订阅者
> 发布者类定义了一系列事件，其他类可通过“注册”这种方式获取发布者的通知，以便于事件触发时来通知他们，执行订阅者提交的事件处理程序。
> ### 注意
> * 发布者 发布某个事件的类或结构，其他类可以在该事件发生时得道通知。
> * 订阅者 注册并在事件发生时得道通知的类或结构。
> * 事件处理程序 由订阅者注册到事件的方法，在发布者触发事件时执行。
> * 触发事件 调用或触发事件的术语，当事件触发时。所有注册到他的方法都会依次调用。
> ### 事件与委托很多行为类似，事件内部包含了一个私有的委托，事件是一种特殊的委托。

## 事件的使用
> ### 事件在使用时分5部分
> * 委托类型的声明 
>   + 事件和事件处理程序必须有共同的签名和返回类型，他们通过委托类型进行描述。
> * 事件处理程序声明
>   + 订阅类中会在事件触发时执行的方法声明。他不一定是有显示的命名方法，还可以是匿名方法或者`Lambda`表达式
> * 事件声明
>   + 发布者必须声明一个订阅者类可以注册的事件成员，当声明的事件为`public`时。被称为发布了事件。
> * 事件注册
>   + 订阅者必须订阅事件才能在他被触发时得到通知。
> * 触发事件的代码
>   + 发布者类中“触发”事件并导致调用注册的所有事件处理程序代码。
> ### 例
>
	class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();//发布者
            Dozens dozens = new Dozens(incrementer);//订阅者
            incrementer.DoCount();//执行方法，达成一定条件触发事件
            Console.WriteLine("Number：{0}", dozens.Dozensount);//触发的事件改变了订阅者类中的属性
            Console.ReadKey();
        }
    }
    class Incrementer//发布者
    {
       public delegate void Handler();
        public event Handler Event_Test;//自定义委托类型的事件
        public event EventHandler CountedADozen;//系统定义委托的事件
        public void DoCount()
        {
            for (int i = 1; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                {//每计数12后触发一次事件，触发事件前先确定是否注册
                    CountedADozen(this, null);
                    Event_Test();
                }
        }
    }
    class Dozens//订阅者
    {
        public int Dozensount { get; private set; }
        public Dozens(Incrementer incrementer)//构造函数
        {
            Dozensount = 0;
            incrementer.CountedADozen += IncrementDozensCount;//订阅事件
            incrementer.Event_Test += () =>         
                Console.WriteLine("Enevt_Test");
            //Lambda表达式订阅的事件
        }
        void IncrementDozensCount(object s,EventArgs e)//事件处理程序
        {
            Dozensount++;
        }
    }

## 声明事件
> ### 语法
>
	public event EventHandler CountedADozen;
> ### 如下图所示
> ![](https://i.imgur.com/qBssejZ.png)
> ### 注意
> * 事件声明在一个类中
> * 他需要委托类型的名称，任何附加到事件的处理程序都必须与委托类型的签名和返回类型匹配
> * 他的声明为`public` ，这样其他类和结构可以在它上面注册事件处理程序。
> * 不能用对象创建表达式（`new`表达式）来创建他的对象。  
> 我们可以使用逗号分隔的列表在声明语句中声明一个以上的事件。
>### 例
>
		public event EventHandler MyEvent1,MyEvent2，OtherEvent;
> 我们还可以使用`static`关键字让事件变成静态的
> ### 事件是成员
> * 同方法、属性一样，事件是类或结构的成员
>   + 不能在一段可执行代码中声明事件
>   + 他必须声明在类或结构中，和其他成员一样
> * 事件成员被隐式自动初始化为`NULL`  
> 
> **BCL声明了一个叫做EventHandler的委托，专门用于系统事件**

## 订阅事件
> 订阅者向事件添加事件处理程序。
> 
> * 使用`+=`运算符来为事件增加事件处理程序
> * 事件处理程序的规范可以是以下任意一种：
>   + 实例方法的名称
>   + 静态的方法名
>   + 匿名方法
>   + `Lambda`表达式
> ### 例
>
		//方法引用形式
		incrementer.CountedADozen += IncrementDozensCount;//实例方法
		incrementer.CountedADozen += classB.CounterHanderlerB;//静态方法
		//委托形式
		incrementer.CountedADozen +=new EvevtHandler(cc.CounterHanderlerC);
		incrementer.CountedADozen += () => Dozensount ++;//Lambda表达式
		incrementer.CountedADozen += delegate { Dozensount ++ ;};//匿名方法

## 触发事件
> 事件本身只是保存了需要被调用的事件处理程序，如果不调用则什么都不会发生。
> ### 注意
> * 在触发事件之前应该和`null`进行比较，从而查看是否包含事件处理程序，如果事件是`null`，则表示事件的调用列表中没有方法，不能调用
> * 调用事件和调用方法一样，使用事件名称，后面跟的参数列表包含在圆括号中，参数列表必须与事件的委托类型相匹配  


## 标准事件的用法
> 事件使的标准模式的根本就是`System`命名空间声明的`EventHandler`委托类型。  
> 关于`EventHandler`委托类型需要注意以下几点： 
>  
> * 第一个参数保存触发事件的对象的引用。由于是`object`类型，所以可以匹配任何类型的实例。
> * 第二个参数是用来保存状态信息，指明什么类型适用于该应用类型
> * 返回类型是`void`
> #### EventHandler声明代码
>
		public delegate void EventHandler(object sender, EventArgs e);
> #### 在使用此委托类型时要注意的地方
> * `EventArgs`类设计为不能传递任何参数，它用于不需要传递数据的事件处理程序
> * 如果要传递参数，必须声明一个派生自`EventHandler`的类。使用合适的字段来保存需要传递的参数
> 
> **EventHandler委托类型的使用实例在文章开头处**

## 通过扩展EventArgs来传递参数
> 为了向自己的事件处理程序的第二个参数传入数据，并且又符合标准惯例，我们需要声明一个派生自`EventArgs`的自定义类，保存我们传递的参数
> ### 例
>
		public class IncrementerEventAgs : EventArgs {
			public int IterationCount { get; set;}
		}
>![](https://i.imgur.com/rXb9Q44.png)
>![](https://i.imgur.com/gRLEXIY.png)  
>
> 使用委托的泛型版本`EventHandler<>`，定义事件
> ### 例
>
	class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();//发布者
            Dozens dozens = new Dozens(incrementer);//订阅者
            incrementer.DoCount();//满足条件时触发事件
            Console.WriteLine("Number：{0}", dozens.DozensCount);
            Console.ReadKey();
        }
    }
    class IncrementerEventArgs: EventArgs//自定义类,派生自EventArgs
    {
        public int IterationCount { get;  set; }
    }
    class Incrementer//发布者
    {
        public event EventHandler<IncrementerEventArgs> CountedADozen;//使用自定义类的泛型委托
        public void DoCount()
        {
            IncrementerEventArgs eventArgs = new IncrementerEventArgs();//自定义类对象
            for(int i=1;i<100;i++)
                if (i % 12 == 0 && CountedADozen != null)
                {
                    eventArgs.IterationCount = i;
                    CountedADozen(this, eventArgs);//触发事件
                }
        }
    }
    class Dozens//订阅者类
    {
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount ;//注册事件
        }
        void IncrementDozensCount(object s,IncrementerEventArgs e)//处理程序
        {
            DozensCount++;
            Console.WriteLine("Incremented {0} in {1}", e.IterationCount, s.ToString());
        }
    }

## 移除事件处理程序
> `-=`运算符用来移除事件处理程序  
> **如果一个处理程序向事件注册了多次，那么当执行命令移除处理程序时。将只移除列表中该处理程序的最后一个实例**


## 事件访问器
> 事件是一种特殊的多播委托，只能从声明它的类中进行调用。 客户端代码通过提供对应在引发事件时调用的方法的引用来订阅事件。 这些方法通过事件访问器添加到委托的调用列表中，事件访问器类似于属性访问器，不同之处在于事件访问器命名为` add `和 `remove`。
> ### 例
> 下面的示例演示如何实现自定义的` add `和` remove `事件访问器。 虽然可以替换访问器内的任何代码，但建议先锁定事件，再添加或删除新的事件处理程序方法。
>
		event EventHandler IDrawingObject.OnDraw
		{
		    add
		    {
		        lock (objectLock)
		        {
		            PreDrawEvent += value;
		        }
		    }
		    remove
		    {
		        lock (objectLock)
		        {
		            PreDrawEvent -= value;
		        }
		    }
		}
				