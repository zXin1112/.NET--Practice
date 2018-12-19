# Asp.Net MVC

## C-Controller(控制器)

### 控制器
> 控制器是应用程序中处理用户交互的部分。
通常控制器从视图读取数据、控制用户输入，并向模型发送数据数据。

* 新建`Controller`，添加行为方法(`Action`)
访问时，使用`ControllerName/ActionName`访问此行为方法
* 当控制器中的行为方法（`Action`）无需外部访问时，可添加特性`[NonAction]`,使得外部无法访问

## V-View(视图)

### 视图
> 
View（视图）是应用程序中处理数据显示的部分。
通常从模型数据中创建视图。

* 在控制器中的`Action`上右键可添加新的`View`视图，视图名最好和`Action`名一致，否则 在`return View()`中添加视图名参数 如`return View("MyView")`
* 关于传递参数
	* 可使用强类型传参
	* ViewData
	* ViewBag

![](https://i.imgur.com/HbLfrIX.png)

## M-Model(模型)
### 模型
> 模型（Model）是应用程序中用于处理应用程序数据逻辑的部分。
通常模型对象在数据库中存取数据。
>
MVC 模型包含所有应用程序逻辑（业务逻辑、验证逻辑、数据访问逻辑），除了纯视图和控制器逻辑。
通过 MVC，模型可保存并操作应用程序数据。


## 三者关系
![](https://i.imgur.com/L1sfLw8.png)

## HtmlHelper相关用法

### 简介
> 在`ASP.NET MVC5`的`View`页面中，`HtmlHelper`被用来输出`HTML`代码。更官方点的描述,`System.Web.Mvc.HtmlHelpe`r对象，该对象用于呈现`HTML`元素。
> * 使用它的几点原因
	* 直接写`HTML`的话如果语句有语法错误，如缺少结尾标记`</b>`，编译器不会报错，出来的页面可能会很乱且难以查出错误在哪。如果用`HtmlHelper`在编译的时候就会指出错误，可以及时修改。
	* `View`中的页面一般都是动态页面，也就是说如果没有`HtmlHelper`，我们经常会写如`<input type="text" value="@id">`这样的服务器端代码和`HTML`代码的混合代码。这样写不仅形式混乱、执行顺序不好判断，而且出错也不容易发现，不如全部用`HtmlHelper`写成服务器端代码。而且用`HtmlHelper`做数据绑定更方便。
	* `HtmlHelper`和`HTML`语言的关系，我觉得跟`Linq`和`SQL`语言的关系差不多。就是说微软给你提供了一种方式让你在不熟悉`HTML`或`SQ`L这种非`.NET`语言的时候，使用.NET框架内的与之等价的类来帮助你更好的解决问题。

### 链接

* ActionLink
 
		@Html.ActionLink("LinkText", "ActionName")
		@Html.ActionLink("LinkText", "ActionName", "ControllerName")
		@Html.ActionLink("LinkText", "ActionName", new { id = 1 })
	* `LinkText`是链接显示出的文字，如果`ActionLink`的参数中给出`Controller`则链接指向对应的`Controller`下的Action。如果没有给出`Controller`则指向当前页面对应的`Controller`下的`Action`。如果`ActionLink`的参数中给出要传递的参数，如`id`，则在链接的最后写出`id`值。
	* 例如
			@Html.ActionLink("LinkText", "GetString")
            @Html.ActionLink("LinkText", "GetString", "Test")
            @Html.ActionLink("LinkText", "GetParameters", new { id = 10000 })
![](https://i.imgur.com/DPNIlyL.png)
* RouteLink
		@Html.RouteLink("LinkText", new { action = "ActionName" })
		@Html.RouteLink("LinkText", new { action = "ActionName", controller = "ControllerName" })
		@Html.RouteLink("LinkText", new { action = "ActionName", id = 1 })
	* 从上面代码可以看出`LinkText`依然是链接显示的文字，而链接的其他信息则包含在`RouteLink`的第二个参数中。这个参数是个`Object`，它的`action`属性表示指向的`Action`而`controlle`r属性表示指向的`Controller`。如果没有`controller`属性则指向当前`Controlle`r。`id`属性则为要传递的参数。
	* 例如
			@Html.RouteLink("LinkText", new { action = "GetString" })
		    @Html.RouteLink("LinkText", new { action = "GetString", controller = "Test" })
		    @Html.RouteLink("LinkText", new { action = "GetParameters", id = 10000 })
![](https://i.imgur.com/JQdGTDY.png)
### 表单元素

* TextBox
		@Html.TextBox("NameId")
		@Html.TextBox("NameId","Value")
	* 可见`TextBox`的第一个参数被赋值给`input`标签的`id`和`name`属性，如果没有`value`参数则`value`为空，如果有则赋值给`value`属性。
	* 例如
			@Html.TextBox("TextBoxId")
	        @Html.TextBox("TextBoxId1", "TextBoxValue")
![](https://i.imgur.com/CIbqfXg.png)
* Hidden
		@Html.Hidden("NameId")
		@Html.Hidden("NameId", "Value")
	* `Hidden`用来在页面中写入`<input type="hidden">`标签，其用法和`TextBox`类似。
	* 例如
			@Html.Hidden("HiddenId")
	        @Html.Hidden("HiddenId1", "HiddenValue")
![](https://i.imgur.com/X3lK7dj.png)
* Password
		@Html.Password("NameId")
		@Html.Password("NameId", "Value")
	* `Password`用来写入`<input type="password">`标签，其用法和`TextBox`类似。
	* 例如
		 	@Html.Password("PasswordId")
			@Html.Password("PasswordId1", "PasswordValue")
![](https://i.imgur.com/mJsWvbx.png)
* CheckBox
		@Html.CheckBox("NameId", true)
		@Html.CheckBox("NameId", false)
	* 本来，正常情况下它应该只生成一个`<input type="checkbox">`的标签，如果CheckBox第二个参数是`true`则有`checked="checked"`属性，表示这个框打勾。但是为这个标签有`value="true"`而且后面还有个尾巴`<input name="NameId" type="hidden" value="false" />`
	* 因为在我们`ASP.NET MVC`中这样子写的效果就是：如果这个`CheckBo`x打勾了，那么提交之后就会传给目标页面一个`NameId="true"`的值，如果没打勾就会传一个`NameId="false"`的值。这个值就是由`<input name="NameId" type="hidden" value="false" />`传递的。若是没有`<input name="NameId" type="hidden" value="false" />`这一段，如果打勾了之后提交，仍然会传给目标页面一个`NameId="true"`的值，而不打勾则不会传`NameId`的值过去。
	* 例如
			@Html.CheckBox("CheckBoxId", true)
	        @Html.CheckBox("CheckBoxId", false)
![](https://i.imgur.com/qGifmue.png)
* RadioButton
		@Html.RadioButton("NameId","Value", true)
		@Html.RadioButton("NameId", "Value", false)
	* 可以看出`RadioButton`和`CheckBox`一样都有`checked`参数，而`RadioButton`多了一个`Value`参数可以设置。
	* 例如
			@Html.RadioButton("RadioButtonId", "Value", true)
			@Html.RadioButton("RadioButtonId", "Value", false)
![](https://i.imgur.com/SXVKUxR.png)
* DropDownList
		@Html.DropDownList("Id", list)
	* `DropDownList`函数可以创建`<select>`标签表示的下拉菜单。在创建下拉菜单之前我们需要创建用`<option>`标签表示的菜单选项列表
	* 例如
			@{
				SelectListItem item;
				List<SelectListItem> list = new List<SelectListItem>();
				for (int i = 1; i < 5; i++)
				{
				    item = new SelectListItem();
				    item.Text = "Text" + i;
				    item.Value = "Value" + i;
				    item.Selected = (i == 2);
				    list.Add(item);
				}
			}
			@Html.DropDownList("ListBoxId", list)
![](https://i.imgur.com/ogbFndN.png)
* ListBox
		@Html.ListBox("NameId", list)
	* `ListBox`可以生成一个多选列表框，对应HTML里的`<select multiple="multiple">`标签，ListBox的结构和DropdownList的结构基本一样，只是多了`multiple="multiple"`属性。
	* 例如
			@Html.ListBox("ListBoxId", list)
![](https://i.imgur.com/nQragpK.png)
* 添加属性
		@Html.TextBox("NameId", "Value", new { @class = "classText",@style="width:200px" })
	* 想给一个标签添加`class`和`style`
	* 例如
			@Html.TextBox(
				"NameId", "Value", 
				new { @class = "classText", @style = "width:200px;box-shadow: 0 0 10px rgba(0,0,0,0.5);" 
				})
![](https://i.imgur.com/GygFOpa.png)

### 表单提交

* 两种方法
	* 方法一
			@using (Html.BeginForm("actionName", "controllerName", FormMethod.Get))
			{
			    @Html.TextBox("NameId")
			    <input type="submit" value="SubmitButton" />
			}
		* 将`Html.BeginForm()`函数放入`@using (){}`结构中这种方法可以直接生成form的开始标记和结束标记
		* 例如
				@using (Html.BeginForm("SubmitForm_Get", "HtmlHelper", FormMethod.Get))
	            {
	                @Html.TextBox("Get_TextBoxID")
	                @Html.CheckBox("Get_CheckBoxID", true)
	                <input type="submit" value="提交" />
	            }
	* 方法二
			@{Html.BeginForm("actionName", "controllerName", FormMethod.Post);}
		    @Html.TextBox("NameId")
		    <input type="submit" value="SubmitButton" />
		* 写`Html.BeginForm()`函数生成开始标记，再在最后写`Html.EndForm()`函数生成结尾标记
		* 例如
				@{ Html.BeginForm("SubmitForm_Post", "HtmlHelper", FormMethod.Post);}

	            @Html.TextBox("Post_TextBoxID")
	            @Html.CheckBox("Post_CheckBoxID", false)
	            <input type="submit" value="提交" />

				@{Html.EndForm();}

### TagBuilder创建自定义标签
* `TagBuilder`就是标签建造器，我们就用它来建造属于我们自己标签生成函数。
* 例如 `HtmlHelper`中没有提交按钮，可使用`TageBuilder`来创建标签
	* 创建一个名为`HtmlExtensions.cs`的类，添加`HtmlHelper`的扩展方法
	![](https://i.imgur.com/3xwn4Af.png)
	* 在`View`中写入下面代码调用刚才写好的函数：
			@Html.Submit("SubmitButton")
![](https://i.imgur.com/fsIoIjE.png)

**注意** 在`View`中使用扩展方法时，应添加扩展方法所在类的`namespace`

### 强类型的HtmlHelper
* 在控制器中传入`Model`
![](https://i.imgur.com/ed8ODGC.png)
* 在`View`中接收`Model`，并使用
			@model Asp.Net_MvcPractice.Models.EmployeeViewModel @*在View页面顶部，接收*@
			@*使用*@
			@model SlarkInc.Models.Simple 
			@Html.TextBoxFor(m =>m.Name)
![](https://i.imgur.com/dOgvLec.png)

### LabelFor数据标签

* 这里我们就要用到`DataAnnotations`，有人叫它元数据，或者叫数据批注。简单来说它就是对数据的描述。之后用`HtmlHelpe`r的`LabelFor`就可以读到这个信息并显示出来。
![](https://i.imgur.com/I2WSlfJ.png)
* 在对应的`View`中
![](https://i.imgur.com/BrZi6fG.png)

![](https://i.imgur.com/rwjWAkM.png)

### DisplayFor 和 EditorFor显示和编辑Model数据

* 在`HtmlHelper`中`DisplayFor`是用来显示数据的，而`EditorFor`是用来编辑数据的。它们都会根据元数据对数据的描述生成不同类型的`HTML`元素。
![](https://i.imgur.com/o1GvfLv.png)
* 在对应的`View`中
![](https://i.imgur.com/KP0aO2X.png)

![](https://i.imgur.com/GAHMkAI.png)




