# SQL高级

学习的SQL语句用于SQLServer的

## SQL TOP 子句
>TOP 子句用于规定要返回的记录的数目。  
对于拥有数千条记录的大型表来说，TOP 子句是非常有用的。
> ### SQL TOP 语法
>		 SELECT TOP number|percent column_name(s) FROM table_name
> ### SQL TOP 例
 	 SELECT TOP 2 * FROM Persons
> ### 或
		SELECT TOP 50 PERCENT * FROM Persons
此处`PERCENT`为百分比

## SQL LIKE 操作符
> LIKE 操作符用于在 WHERE 子句中搜索列中的指定模式。
> ### SQL LIKE 语法
		SELECT column_name(s) FROM table_name WHERE column_name LIKE pattern
> ### SQL LIKE 例
> 从"Persons" 表中选取居住在以 "N" 开始的城市
> 
		 SELECT * FROM Persons WHERE City LIKE 'N%'
## SQL 通配符
> 在搜索数据库中的数据时，SQL 通配符可以替代一个或多个字符。  
SQL 通配符必须与 LIKE 运算符一起使用。
>
![](https://i.imgur.com/B8DQXOe.png)

## SQL IN 操作符
> IN 操作符允许我们在 WHERE 子句中规定多个值。
> ### SQL IN 语法
>
	SELECT column_name(s) FROM table_name WHERE column_name IN (value1,value2,...)
> ### SQL IN 语法 例
> 选取姓氏为 Adams 和 Carter 的人
> 
		 SELECT * FROM Persons WHERE LastName IN ('Adams','Carter')

## SQL BETWEEN 操作符
> 操作符 BETWEEN ... AND 会选取介于两个值之间的数据范围。这些值可以是数值、文本或者日期。
> ### SQL BETWEEN 语法
			 SELECT column_name(s) FROM table_name WHERE column_name BETWEEN value1 AND value2
> ### SQL BETWEEN 例
> 以字母顺序显示介于 "Adams"（包括）和 "Carter"（不包括）之间的人
> 
		 SELECT * FROM Persons WHERE LastName BETWEEN 'Adams' AND 'Carter'
> **重要事项**：不同的数据库对 BETWEEN...AND 操作符的处理方式是有差异的。某些数据库会列出介于 "Adams" 和 "Carter" 之间的人，但不包括 "Adams" 和 "Carter" ；某些数据库会列出介于 "Adams" 和 "Carter" 之间并包括 "Adams" 和 "Carter" 的人；而另一些数据库会列出介于 "Adams" 和 "Carter" 之间的人，包括 "Adams" ，但不包括 "Carter" 。
> ### 如需使用上面的例子显示范围之外的人，使用 NOT 操作符
		SELECT * FROM Persons WHERE LastName NOT BETWEEN 'Adams' AND 'Carter'

## SQL Alias（别名）
> 通过使用 SQL，可以为列名称和表名称指定别名（Alias）。
> 表的 SQL Alias 语法
>
		SELECT column_name(s) FROM table_name AS alias_name
> 列的 SQL Alias 语法
>
		SELECT column_name AS alias_name FROM table_name

> ### Alias 实例: 使用表名称别名
> 假设我们有两个表分别是："Persons" 和 "Product_Orders"。我们分别为它们指定别名 "p" 和 "po"。

		SELECT po.OrderID, p.LastName, p.FirstName FROM Persons AS p, Product_Orders AS po WHERE p.LastName='Adams' AND p.FirstName='John'
> ### Alias 实例: 使用一个列名别名
			SELECT LastName AS Family, FirstName AS Name FROM Persons

## SQL JOIN
> SQL join 用于根据两个或多个表中的列之间的关系，从这些表中查询数据
> ### SQL JOIN 例
> 使用关键词 JOIN 来从两个表中获取数据
> 
		SELECT Persons.LastName, Persons.FirstName, Orders.OrderNo FROM Persons INNER JOIN Orders ON Persons.Id_P = Orders.Id_P ORDER BY Persons.LastName
> ### 除了我们在上面的例子中使用的 INNER JOIN（内连接），我们还可以使用其他几种连接。
> * JOIN: 如果表中有至少一个匹配，则返回行
> * LEFT JOIN: 即使右表中没有匹配，也从左表返回所有的行
> * RIGHT JOIN: 即使左表中没有匹配，也从右表返回所有的行
> * FULL JOIN: 只要其中一个表中存在匹配，就返回行


## SQL INNER JOIN 关键字
> 在表中存在至少一个匹配时，INNER JOIN 关键字返回行。
> ### INNER JOIN 关键字语法
>
		SELECT column_name(s)
		FROM table_name1
		INNER JOIN table_name2 
		ON table_name1.column_name=table_name2.column_name
> ### 内连接（INNER JOIN）实例
> 使用关键词 INNER JOIN 来从两个表中获取数据
> 
		SELECT Persons.LastName, Persons.FirstName, Orders.OrderNo
		FROM Persons
		INNER JOIN Orders
		ON Persons.Id_P=Orders.Id_P
		ORDER BY Persons.LastName

## SQL LEFT JOIN 关键字
> LEFT JOIN 关键字会从左表 (table_name1) 那里返回所有的行，即使在右表 (table_name2) 中没有匹配的行。
> ### LEFT JOIN 关键字语法
		SELECT column_name(s)
		FROM table_name1
		LEFT JOIN table_name2 
		ON table_name1.column_name=table_name2.column_name
> ### 左连接（LEFT JOIN）实例
>  如果有订购的话，列出所有的人，以及他们的定购。
>  
		SELECT Persons.LastName, Persons.FirstName, Orders.OrderNo
		FROM Persons
		LEFT JOIN Orders
		ON Persons.Id_P=Orders.Id_P
		ORDER BY Persons.LastName

## SQL RIGHT JOIN 关键字
> RIGHT JOIN 关键字会右表 (table_name2) 那里返回所有的行，即使在左表 (table_name1) 中没有匹配的行。
> ### RIGHT JOIN 关键字语法
>
		SELECT column_name(s)
		FROM table_name1 
		RIGHT JOIN table_name2 
		ON table_name1.column_name=table_name2.column_name

> ### 右连接（RIGHT JOIN）实例
> 所有的定单，以及定购它们的人 - 如果有的话
> 
		SELECT Persons.LastName, Persons.FirstName, Orders.OrderNo
		FROM Persons RIGHT JOIN
		Orders ON Persons.Id_P=Orders.Id_P
		ORDER BY Persons.LastName


## SQL FULL JOIN 关键字
> 只要其中某个表存在匹配，FULL JOIN 关键字就会返回行。
>  ### FULL JOIN 关键字语法
>
		SELECT column_name(s)
		FROM table_name1
		FULL JOIN table_name2 
		ON table_name1.column_name=table_name2.column_name

> ### 全连接（FULL JOIN）实例
> 列出所有的人，以及他们的定单，以及所有的定单，以及定购它们的人。
> 
		SELECT Persons.LastName, Persons.FirstName, Orders.OrderNo
		FROM Persons
		FULL JOIN Orders
		ON Persons.Id_P=Orders.Id_P
		ORDER BY Persons.LastName