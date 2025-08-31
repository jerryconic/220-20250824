USE db01;

SELECT * FROM dbo.Employee
WHERE emp_id = 3;

SELECT * FROM dbo.Employee
WHERE salary <= 40000;

SELECT emp_id, emp_name FROM dbo.Employee
WHERE salary <= 40000;

SELECT emp_id, emp_name FROM dbo.Employee
WHERE birth_date > '1991-1-1';

SELECT emp_id, emp_name FROM dbo.Employee
WHERE emp_name <> 'John';
