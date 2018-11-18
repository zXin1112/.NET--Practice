# SQL基础语句

学习的SQL语句用于SQLServer

## SQL SELECT
> SELECT 语句用于从表中选取数据。
结果被存储在一个结果表中（称为结果集）。
> ### 语法
		SELECT 列名称 FROM 表名称
> ### 或
>
		SELECT * FROM 表名称

> ### SQL SELECT 例
查询所有列的内容
>
		SELECT * FROM table_name




## SQL SELECT DISTINCT 语句
> 关键词 DISTINCT 用于返回唯一不同的值。。
> ### 语法
		SELECT DISTINCT  列名称 FROM 表名称

> ### SQL SELECT DISTINCT  例
查询所有列的内容,列的内容无重复值
>
		SELECT DISTINCT  * FROM table_name

## WHERE 子句
> 有条件的从表中查询数据
> ### 语法
		SELECT 列名称 FROM 表名称 WHERE 列 运算符 值
> ### 此语句有以下操作符
> ![](https://i.imgur.com/oG9YHPg.png)
> ### WHERE 子句 例
查询指定ID的内容
>
		SELECT * FROM table_name WHERE column_name=Value

## SQL AND & OR 运算符
> AND 和 OR 可在 WHERE 子语句中把两个或多个条件结合起来。  
> 如果第一个条件和第二个条件都成立，则 AND 运算符显示一条记录。  
如果第一个条件和第二个条件中只要有一个成立，则 OR 运算符显示一条记录。
> ### SQL AND & OR 运算符 例
查询对应条件的数据
>
		SELECT * FROM table_name WHERE column_name1=Value1 AND column_name2=Value2
> ### 或
>
		SELECT * FROM table_name WHERE column_name1=Value1 OR column_name2=Value2

## ORDER BY 语句
> ORDER BY 语句用于根据指定的列对结果集进行排序。  
ORDER BY 语句默认按照升序对记录进行排序。  
如果您希望按照降序对记录进行排序，可以使用 DESC 关键字。
> ### ORDER BY 语句 例
>
		SELECT * FROM table_name ORDER BY column_name
> ### 或
>
		SELECT * FROM table_name ORDER BY column_name DESC

## SQL INSERT INTO 语句
> INSERT INTO 语句用于向表格中插入新的行。
> ### 语法
		INSERT INTO 表名称 VALUES (值1, 值2,....)
> ### 或 指定列名填充数据
> 
		INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
> ### SQL INSERT INTO 例
插入一行数据
>
		INSERT INTO table_name VALUES (Value1, Value2,....)
> ### 或
> 
		INSERT INTO table_name (column_name1, column_name2,...) VALUES (Value1, Value2,....)

## SQL UPDATE 语句
> Update 语句用于修改表中的数据。
> ### 语法
		UPDATE 表名称 SET 列名称 = 新值 WHERE 列名称 = 某值
> ### SQL UPDATE 例
> 
	UPDATE table_name SET column_name1 = Value1, column_name2 = Value2 WHERE column_name3 = Value3

## SQL DELETE 语句
> DELETE 语句用于删除表中的行。
> ### 语法
		DELETE FROM 表名称 WHERE 列名称 = 值
> ### SQL DELETE 例
> 删除所有行
> 
		DELETE FROM table_name
> 删除指定行
> 
		DELETE FROM table_name WHERE column_name1 = Value3
 