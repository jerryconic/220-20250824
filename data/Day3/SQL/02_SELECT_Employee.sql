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

SELECT * FROM dbo.Employee
WHERE emp_id IN (1, 3, 5);

SELECT * FROM dbo.Employee
WHERE salary BETWEEN 30000 AND 40000;

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'A%';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE '%A%';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE '%A';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'J___';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'J____';

UPDATE dbo.Employee
SET emp_name = 'xxx', salary = 0
WHERE emp_id = 3;

DELETE FROM dbo.Employee
WHERE emp_id = 4;

SELECT * FROM dbo.Employee;