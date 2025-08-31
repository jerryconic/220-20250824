USE db01;
--Ctrl + Shift + R

DROP TABLE IF EXISTS dbo.Employee
GO
CREATE TABLE dbo.Employee
(
emp_id int PRIMARY KEY,
emp_name nvarchar(20),
birth_date date,
salary int
);


INSERT INTO dbo.Employee(emp_id, emp_name, birth_date, salary)
VALUES(1, 'John', '1990-1-1', 40000),
(2, 'Peter', '1991-1-1', 46000),
(3, 'Linda', '1992-1-1', 42000),
(4, 'Alice', '1993-1-1', 38000);

SELECT * FROM dbo.Employee;